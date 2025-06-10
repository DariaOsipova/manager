using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class ContractNumberNullException : ArgumentNullException
    {
        public ContractNumberNullException(string paramName)
            : base(paramName, "Contract number cannot be null or whitespace.") { }
    }

}
