using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class MessageTooLongException : ArgumentException
    {
        public string MessageText { get; }
        public int MaxLength { get; }

        public MessageTooLongException(string message, int maxLength)
            : base($"Message exceeds the maximum allowed length of {maxLength}.")
        {
            MessageText = message;
            MaxLength = maxLength;
        }
    }

}
