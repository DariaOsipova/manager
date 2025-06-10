using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AddressTooShortException : ArgumentException
    {
        public string Address { get; }
        public int MinLength { get; }

        public AddressTooShortException(string address, int minLength)
            : base($"Address '{address}' is shorter than the minimum required length of {minLength}.")
        {
            Address = address;
            MinLength = minLength;
        }
    }

}
