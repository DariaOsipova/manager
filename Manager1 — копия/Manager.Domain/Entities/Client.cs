using Manager.Domain.Entities.Base;
using Manager.ValueObjects;
using Manager.Domain.Exceptions;

namespace Manager.Domain.Entities;

public class Client : Entity<Guid>
{
    public UserName Name { get; private set; }
    public ContactInfo Contacts { get; private set; }

    private readonly ICollection<Guid> _requests = new List<Guid>();
    private readonly ICollection<Guid> _deals = new List<Guid>();

    public ICollection<Guid> Requests => _requests;
    public ICollection<Guid> Deals => _deals;

    public DateTime RegistrationDate { get; private set; }
    public bool IsVip { get; private set; }

    public Client(string name, ContactInfo contacts)
         : this(Guid.NewGuid(), new UserName(name), contacts) { }

    protected Client(Guid id, UserName name, ContactInfo contacts)
        : base(id)
    {
        Name = name ?? throw new ClientNameNullException(nameof(name));
        Contacts = contacts ?? throw new ClientContactInfoNullException(nameof(contacts));
        RegistrationDate = DateTime.UtcNow;
        IsVip = false;
    }

    /// <summary>Конструктор для EF</summary>
    protected Client() : base(Guid.NewGuid()) { }
    ///<summary>Добавляет идентификатор запроса в список клиента</summary>
    public void AddRequest(Guid requestId)
    {
        if (!_requests.Contains(requestId))
            _requests.Add(requestId);
    }

    ///<summary>Добавляет сделку в список клиента</summary>
    public void AddDeal(Guid dealId)
    {
        if (!_deals.Contains(dealId))
            _deals.Add(dealId);
    }

    ///<summary>Обновляет статус клиента на VIP или обычный</summary>
    public void SetVipStatus(bool isVip)
    {
        IsVip = isVip;
    }

    ///<summary>Обновляет контактную информацию клиента</summary>
    public void UpdateContactInfo(ContactInfo newContacts)
    {
        Contacts = newContacts ?? throw new ClientContactInfoNullException(nameof(newContacts));
    }
}
