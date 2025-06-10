using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AreaTooShortException : ArgumentException
    {
        public string Area { get; }
        public int MinLength { get; }

        public AreaTooShortException(string area, int minLength)
            : base($"Area '{area}' is shorter than the minimum required length of {minLength}.")
        {
            Area = area;
            MinLength = minLength;
        }
    }

}
