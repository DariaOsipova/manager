using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AddressNullException : ArgumentNullException
    {
        public AddressNullException(string paramName)
            : base(paramName, "Address cannot be null or whitespace.") { }
    }

}
