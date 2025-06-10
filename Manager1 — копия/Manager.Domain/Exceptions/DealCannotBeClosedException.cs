using Manager.ValueObjects;

namespace Manager.Domain.Exceptions
{
    public class DealCannotBeClosedException : InvalidOperationException
    {
        public Guid DealId { get; }
        public DealStatus Status { get; }
        public PaymentStatus PaymentStatus { get; }

        public DealCannotBeClosedException(Guid dealId, DealStatus status, PaymentStatus paymentStatus)
            : base($"Deal '{dealId}' cannot be closed. Status: {status}, Payment: {paymentStatus}.")
        {
            DealId = dealId;
            Status = status;
            PaymentStatus = paymentStatus;
        }
    }

}
