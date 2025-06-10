using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class DepartmentTooShortException : ArgumentException
    {
        public string Department { get; }
        public int MinLength { get; }

        public DepartmentTooShortException(string department, int minLength)
            : base($"Department name '{department}' is shorter than the minimum required length of {minLength}.")
        {
            Department = department;
            MinLength = minLength;
        }
    }

}
