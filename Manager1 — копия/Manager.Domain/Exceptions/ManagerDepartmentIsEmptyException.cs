using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ManagerDepartmentIsEmptyException : ArgumentException
    {
        public ManagerDepartmentIsEmptyException(string paramName)
            : base("Manager department cannot be empty or whitespace.", paramName) { }
    }

}
