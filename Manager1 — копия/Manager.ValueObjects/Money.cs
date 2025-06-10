
using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

    /// <summary>
    /// Represents type of the money.
    /// </summary>
    /// <param name="amount">The amount of the money.</param>
    namespace Manager.ValueObjects
    {
        public class Money : ValueObject<decimal>
        {
            public Money(decimal value)
                : base(new MoneyValidator(), value)
            {
            }
        }
    }
