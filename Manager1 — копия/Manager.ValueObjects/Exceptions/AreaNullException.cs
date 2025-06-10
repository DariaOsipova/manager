using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AreaNullException : ArgumentNullException
    {
        public AreaNullException(string paramName)
            : base(paramName, "Area cannot be null or whitespace.") { }
    }

}
