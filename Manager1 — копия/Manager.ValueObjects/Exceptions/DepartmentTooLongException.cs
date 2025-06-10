using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class DepartmentTooLongException : ArgumentException
    {
        public string Department { get; }
        public int MaxLength { get; }

        public DepartmentTooLongException(string department, int maxLength)
            : base($"Department name '{department}' exceeds the maximum allowed length of {maxLength}.")
        {
            Department = department;
            MaxLength = maxLength;
        }
    }

}
