using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContactInfoInvalidFormatException : FormatException
    {
        public string ContactInfo { get; }

        public ContactInfoInvalidFormatException(string contactInfo)
            : base($"Contact info '{contactInfo}' does not contain any letters or digits.")
        {
            ContactInfo = contactInfo;
        }
    }

}
