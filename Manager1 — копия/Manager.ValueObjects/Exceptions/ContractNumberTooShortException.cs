using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContractNumberTooShortException : ArgumentException
    {
        public string ContractNumber { get; }
        public int MinLength { get; }

        public ContractNumberTooShortException(string contractNumber, int minLength)
            : base($"Contract number '{contractNumber}' is shorter than the minimum required length of {minLength}.")
        {
            ContractNumber = contractNumber;
            MinLength = minLength;
        }
    }

}
