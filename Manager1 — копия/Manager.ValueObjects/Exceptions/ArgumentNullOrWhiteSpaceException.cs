using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ArgumentNullOrWhiteSpaceException : ArgumentException
    {
        public string Parameter { get; }

        public ArgumentNullOrWhiteSpaceException(string paramName)
            : base($"The argument '{paramName}' cannot be null, empty, or whitespace.", paramName)
        {
            Parameter = paramName;
        }
    }

}
