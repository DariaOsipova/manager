using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ManagerDepartmentNullException : ArgumentNullException
    {
        public ManagerDepartmentNullException(string paramName)
            : base(paramName, "Manager department cannot be null.") { }
    }

}
