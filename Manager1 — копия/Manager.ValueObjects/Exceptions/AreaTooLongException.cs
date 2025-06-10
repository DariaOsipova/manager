using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class AreaTooLongException : ArgumentException
    {
        public string Area { get; }
        public int MaxLength { get; }

        public AreaTooLongException(string area, int maxLength)
            : base($"Area '{area}' exceeds the maximum allowed length of {maxLength}.")
        {
            Area = area;
            MaxLength = maxLength;
        }
    }

}
