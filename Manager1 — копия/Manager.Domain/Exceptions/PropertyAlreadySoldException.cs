using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class PropertyAlreadySoldException : InvalidOperationException
    {
        public Guid PropertyId { get; }

        public PropertyAlreadySoldException(Guid propertyId)
            : base($"Property '{propertyId}' is already sold.")
        {
            PropertyId = propertyId;
        }
    }

}
