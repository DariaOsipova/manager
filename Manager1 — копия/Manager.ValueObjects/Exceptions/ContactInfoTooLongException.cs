using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContactInfoTooLongException : ArgumentException
    {
        public string ContactInfo { get; }
        public int MaxLength { get; }

        public ContactInfoTooLongException(string contactInfo, int maxLength)
            : base($"Contact info '{contactInfo}' exceeds the maximum allowed length of {maxLength}.")
        {
            ContactInfo = contactInfo;
            MaxLength = maxLength;
        }
    }

}
