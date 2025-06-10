using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class MoneyAmountNonPositiveException : ArgumentOutOfRangeException
    {
        public decimal Amount { get; }

        public MoneyAmountNonPositiveException(string paramName, decimal amount)
            : base(paramName, $"Money amount must be positive. Received: {amount}.")
        {
            Amount = amount;
        }
    }

}
