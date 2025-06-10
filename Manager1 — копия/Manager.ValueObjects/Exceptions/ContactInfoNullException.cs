using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContactInfoNullException : ArgumentNullException
    {
        public ContactInfoNullException(string paramName)
            : base(paramName, "Contact info cannot be null or whitespace.") { }
    }

}
