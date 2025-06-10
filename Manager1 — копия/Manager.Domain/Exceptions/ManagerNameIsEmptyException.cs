using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ManagerNameIsEmptyException : ArgumentException
    {
        public ManagerNameIsEmptyException(string paramName)
            : base("Manager name cannot be empty or whitespace.", paramName) { }
    }

}
