using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class NumberTooLongException : ArgumentException
    {
        public string Number { get; }
        public int MaxLength { get; }

        public NumberTooLongException(string number, int maxLength)
            : base($"Number '{number}' exceeds the maximum allowed length of {maxLength}.")
        {
            Number = number;
            MaxLength = maxLength;
        }
    }

}
