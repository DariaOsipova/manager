using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class DepartmentDoubleWhitespaceException : ArgumentException
    {
        public string Department { get; }

        public DepartmentDoubleWhitespaceException(string department)
            : base($"Department name '{department}' contains double whitespace.")
        {
            Department = department;
        }
    }

}
