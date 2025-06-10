using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class MoneyAmountHasMoreThanTwoDecimalPlacesException : ArgumentException
    {
        public decimal Amount { get; }

        public MoneyAmountHasMoreThanTwoDecimalPlacesException(string paramName, decimal amount)
            : base($"Money amount '{amount}' has more than two decimal places.", paramName)
        {
            Amount = amount;
        }
    }

}
