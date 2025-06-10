using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class NumberInvalidCharactersException : FormatException
    {
        public string Number { get; }

        public NumberInvalidCharactersException(string number)
            : base($"Number '{number}' contains invalid characters. Only digits are allowed.")
        {
            Number = number;
        }
    }

}
