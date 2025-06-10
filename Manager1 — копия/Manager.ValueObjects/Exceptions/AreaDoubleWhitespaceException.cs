using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AreaDoubleWhitespaceException : ArgumentException
    {
        public string Area { get; }

        public AreaDoubleWhitespaceException(string area)
            : base($"Area '{area}' contains double whitespace.")
        {
            Area = area;
        }
    }

}
