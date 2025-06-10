using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AddressTooLongException : ArgumentException
    {
        public string Address { get; }
        public int MaxLength { get; }

        public AddressTooLongException(string address, int maxLength)
            : base($"Address '{address}' exceeds the maximum allowed length of {maxLength}.")
        {
            Address = address;
            MaxLength = maxLength;
        }
    }

}
