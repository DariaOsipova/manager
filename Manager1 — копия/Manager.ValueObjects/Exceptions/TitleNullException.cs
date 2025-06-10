using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class TitleNullException : ArgumentNullException
    {
        public TitleNullException(string paramName)
            : base(paramName, $"Title '{paramName}' cannot be null or whitespace.") { }
    }

}
