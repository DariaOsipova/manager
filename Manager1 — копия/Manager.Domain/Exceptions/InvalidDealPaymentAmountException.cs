using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class InvalidDealPaymentAmountException : ArgumentException
    {
        public decimal Amount { get; }

        public InvalidDealPaymentAmountException(decimal amount)
            : base($"Invalid payment amount: {amount}. Must be greater than zero.")
        {
            Amount = amount;
        }
    }

}
