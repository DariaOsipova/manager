using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ClientContactInfoNullException : ArgumentNullException
    {
        public ClientContactInfoNullException(string paramName)
            : base(paramName, "Client contact info cannot be null.") { }
    }

}
