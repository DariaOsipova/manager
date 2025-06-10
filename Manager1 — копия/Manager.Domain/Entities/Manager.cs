using Manager.Domain.Entities.Base;
using Manager.ValueObjects;
using Manager.Domain.Exceptions;

namespace Manager.Domain.Entities
{
    public class ManagerEntity : Entity<Guid>
    {
        public UserName Name { get; private set; }
        public Department Department { get; private set; }

        ///<summary>Создаёт нового менеджера с именем и отделом</summary>
        public ManagerEntity(string name, string department)
            : this(Guid.NewGuid(), new UserName(name), new Department(department)) { }

        protected ManagerEntity(Guid id, UserName name, Department department)
            : base(id)
        {
            Name = name ?? throw new ManagerNameNullException(nameof(name));
            Department = department ?? throw new ManagerDepartmentNullException(nameof(department));
        }

        /// <summary>Конструктор для EF</summary>
        protected ManagerEntity() : base(Guid.NewGuid()) { }

        ///<summary>Меняет имя менеджера</summary>
        public void ChangeName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ManagerNameIsEmptyException(nameof(newName));

            Name = new UserName(newName);
        }

        ///<summary>Переводит менеджера в другой отдел</summary>
        public void ChangeDepartment(string newDepartment)
        {
            if (string.IsNullOrWhiteSpace(newDepartment))
                throw new ManagerDepartmentIsEmptyException(nameof(newDepartment));

            Department = new Department(newDepartment);
        }
    }
}
