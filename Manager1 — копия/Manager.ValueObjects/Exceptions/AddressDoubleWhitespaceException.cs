using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AddressDoubleWhitespaceException : ArgumentException
    {
        public string Address { get; }

        public AddressDoubleWhitespaceException(string address)
            : base($"Address '{address}' contains double whitespace.")
        {
            Address = address;
        }
    }

}
