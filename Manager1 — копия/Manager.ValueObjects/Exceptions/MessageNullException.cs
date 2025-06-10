using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class MessageNullException : ArgumentNullException
    {
        public MessageNullException(string paramName)
            : base(paramName, $"Message '{paramName}' cannot be null or whitespace.") { }
    }

}
