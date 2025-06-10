using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class DepartmentNullException : ArgumentNullException
    {
        public DepartmentNullException(string paramName)
            : base(paramName, "Department name cannot be null or whitespace.") { }
    }

}
