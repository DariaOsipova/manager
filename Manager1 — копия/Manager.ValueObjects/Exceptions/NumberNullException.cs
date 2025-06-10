using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class NumberNullException : ArgumentNullException
    {
        public NumberNullException(string paramName)
            : base(paramName, $"Number '{paramName}' cannot be null or whitespace.") { }
    }

}
