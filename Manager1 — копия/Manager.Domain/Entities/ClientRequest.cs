using Manager.Domain.Entities.Base;
using Manager.ValueObjects;
using Manager.Domain.Enums;
using Manager.Domain.Exceptions;

namespace Manager.Domain.Entities
{
    public class Request : Entity<Guid>
    {
        public Guid ClientId { get; private set; }
        public Guid PropertyId { get; private set; }
        public Message Message { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public RequestStatus Status { get; private set; }
        public DateTime? ResponseDate { get; private set; }
        public Message? ManagerNotes { get; private set; }

        ///<summary>Создаёт новый запрос на объект недвижимости</summary>
        public Request(Guid clientId, Guid propertyId, string message)
         : this(Guid.NewGuid(), clientId, propertyId, new Message(message)) { }

        protected Request(Guid id, Guid clientId, Guid propertyId, Message message)
            : base(id)
        {
            ClientId = clientId;
            PropertyId = propertyId;
            Message = message;
            CreatedAt = DateTime.UtcNow;
            Status = RequestStatus.Pending;
        }

        /// <summary>Конструктор для EF</summary>
        protected Request() : base(Guid.NewGuid()) { }

        ///<summary>Одобряет запрос и добавляет примечание менеджера</summary>
        public void Approve(string managerNotes)
        {
            if (!CanBeApproved())
                throw new RequestCannotBeApprovedInCurrentStateException(Id, Status);

            Status = RequestStatus.Approved;
            ManagerNotes = new Message(managerNotes);
            ResponseDate = DateTime.UtcNow;
            Update();
        }

        ///<summary>Отклоняет запрос с причиной</summary>
        public void Reject(string reason)
        {
            if (Status == RequestStatus.Approved)
                throw new ApprovedRequestCannotBeRejectedException(Id);

            Status = RequestStatus.Rejected;
            ManagerNotes = new Message(reason);
            ResponseDate = DateTime.UtcNow;
            Update();
        }

        ///<summary>Помечает запрос как 'в процессе'</summary>
        public void MarkAsInProgress()
        {
            if (Status != RequestStatus.Pending)
                throw new OnlyPendingRequestCanBeMarkedInProgressException(Id, Status);

            Status = RequestStatus.InProgress;
            Update();
        }

        ///<summary>Добавляет дополнительный ответ менеджера</summary>
        public void AddResponse(string response)
        {
            ManagerNotes = new Message(response);
            ResponseDate = DateTime.UtcNow;
            Update();
        }

        ///<summary>Проверяет, истёк ли срок ожидания ответа</summary>
        public bool IsExpired()
        {
            return Status == RequestStatus.Pending && CreatedAt.AddDays(3) < DateTime.UtcNow;
        }

        ///<summary>Можно ли одобрить запрос</summary>
        public bool CanBeApproved()
        {
            return Status == RequestStatus.Pending || Status == RequestStatus.InProgress;
        }

        // Метод-заглушка для обновления или доменного события (по необходимости)
        private void Update()
        {
            // например: RaiseDomainEvent(new RequestStatusChanged(...));
        }
    }


}
