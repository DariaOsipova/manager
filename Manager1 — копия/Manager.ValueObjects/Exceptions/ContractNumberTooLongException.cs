using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContractNumberTooLongException : ArgumentException
    {
        public string ContractNumber { get; }
        public int MaxLength { get; }

        public ContractNumberTooLongException(string contractNumber, int maxLength)
            : base($"Contract number '{contractNumber}' exceeds the maximum allowed length of {maxLength}.")
        {
            ContractNumber = contractNumber;
            MaxLength = maxLength;
        }
    }

}
