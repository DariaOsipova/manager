using Manager.Domain.Entities.Base;
using Manager.Domain.ValueObjects;
using Manager.ValueObjects;
using Manager.Domain.Exceptions;
using Manager.Domain.Enums;

namespace Manager.Domain.Entities;

public class Deal : Entity<Guid>
{
    public Guid PropertyId { get; private set; }
    public Guid ClientId { get; private set; }
    public Guid ManagerId { get; private set; }

    public DealType DealType { get; private set; }
    public DealStatus Status { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }

    public Money Price { get; private set; }
    public Money Commission { get; private set; }

    public Number ContractNumber { get; private set; }
    public PaymentStatus PaymentStatus { get; private set; }

    public Message? Notes { get; private set; }
    public Feedback Feedback { get; private set; }

    ///<summary>Создаёт новую сделку по продаже или аренде</summary>
    public Deal(Guid propertyId, Guid clientId, Guid managerId, DealType dealType, decimal price, string contractNumber)
        : this(Guid.NewGuid(), propertyId, clientId, managerId, dealType,
               new Money(price), new Number(contractNumber))
    { }

    protected Deal(Guid id, Guid propertyId, Guid clientId, Guid managerId, DealType dealType,
                   Money price, Number contractNumber)
        : base(id)
    {
        PropertyId = propertyId;
        ClientId = clientId;
        ManagerId = managerId;
        DealType = dealType;
        Price = price;
        ContractNumber = contractNumber;
        Status = DealStatus.Active;
        PaymentStatus = PaymentStatus.Unpaid;
        StartDate = DateTime.UtcNow;
        Commission = CalculateCommission();
    }

    /// <summary>Конструктор для EF</summary>
    protected Deal() : base(Guid.NewGuid()) { }
    ///<summary>Завершает сделку</summary>
    public void CloseDeal()
    {
        if (!CanBeClosed())
            throw new DealCannotBeClosedException(Id, Status, PaymentStatus);

        Status = DealStatus.Completed;
        EndDate = DateTime.UtcNow;
        Update();
    }

    ///<summary>Отменяет сделку с указанием причины</summary>
    public void CancelDeal(string reason)
    {
        if (Status == DealStatus.Completed)
            throw new CompletedDealCannotBeCancelledException(Id);

        Status = DealStatus.Cancelled;
        Notes = new Message(reason);
        EndDate = DateTime.UtcNow;
        Update();
    }

    ///<summary>Продлевает аренду, если сделка — аренда</summary>
    public bool ExtendRental(DateTime newEndDate)
    {
        if (DealType != DealType.Rent || Status != DealStatus.Active)
            return false;

        EndDate = newEndDate;
        Update();
        return true;
    }

    ///<summary>Добавляет платёж и обновляет статус оплаты</summary>
    public void AddPayment(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidDealPaymentAmountException(amount);

        if (PaymentStatus == PaymentStatus.Paid)
            throw new DealAlreadyPaidException(Id);

        if (amount >= Price.Value)
        {
            PaymentStatus = PaymentStatus.Paid;
        }
        else
        {
            PaymentStatus = PaymentStatus.PartiallyPaid;
        }

        Update();
    }

    ///<summary>Проверяет, просрочена ли сделка</summary>
    public bool IsOverdue()
    {
        return PaymentStatus == PaymentStatus.Unpaid && DateTime.UtcNow > StartDate.AddDays(30);
    }

    ///<summary>Можно ли завершить сделку</summary>
    public bool CanBeClosed()
    {
        return Status == DealStatus.Active && PaymentStatus == PaymentStatus.Paid;
    }

    private Money CalculateCommission()
    {
        var rate = DealType == DealType.Sale ? 0.05m : 0.5m;
        return new Money(Price.Value * rate);
    }

    private void Update()
    {
        // для domain events, auditing и т.д.
    }
}
