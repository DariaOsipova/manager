using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class RoomNullException : ArgumentNullException
    {
        public RoomNullException(string paramName)
            : base(paramName, $"Room '{paramName}' cannot be null or whitespace.") { }
    }

}
