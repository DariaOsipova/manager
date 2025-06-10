using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ClientNameNullException : ArgumentNullException
    {
        public ClientNameNullException(string paramName)
            : base(paramName, "Client name cannot be null.") { }
    }

}
