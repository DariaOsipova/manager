using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class PersonNameNullException : ArgumentNullException
    {
        public PersonNameNullException(string paramName)
            : base(paramName, $"Name '{paramName}' cannot be null or whitespace.") { }
    }

}
