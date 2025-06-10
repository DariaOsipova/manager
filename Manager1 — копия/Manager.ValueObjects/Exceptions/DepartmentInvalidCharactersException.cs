using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class DepartmentInvalidCharactersException : ArgumentException
    {
        public string Department { get; }

        public DepartmentInvalidCharactersException(string department)
            : base($"Department name '{department}' contains invalid characters. Only letters and spaces are allowed.")
        {
            Department = department;
        }
    }
}
