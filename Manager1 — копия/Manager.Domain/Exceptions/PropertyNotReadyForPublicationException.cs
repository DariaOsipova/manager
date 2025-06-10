using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class PropertyNotReadyForPublicationException : InvalidOperationException
    {
        public Guid PropertyId { get; }

        public PropertyNotReadyForPublicationException(Guid propertyId)
            : base($"Property '{propertyId}' is not ready for publication.")
        {
            PropertyId = propertyId;
        }
    }

}
