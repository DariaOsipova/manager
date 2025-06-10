using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContractNumberInvalidCharactersException : FormatException
    {
        public string ContractNumber { get; }

        public ContractNumberInvalidCharactersException(string contractNumber)
            : base($"Contract number '{contractNumber}' contains invalid characters. Only letters, digits, '-', and '/' are allowed.")
        {
            ContractNumber = contractNumber;
        }
    }

}
