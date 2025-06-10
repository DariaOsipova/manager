using Manager.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class PropertyNotAvailableForReservationException : InvalidOperationException
    {
        public Guid PropertyId { get; }
        public PropertyStatus CurrentStatus { get; }

        public PropertyNotAvailableForReservationException(Guid propertyId, PropertyStatus status)
            : base($"Property '{propertyId}' cannot be reserved because its status is '{status}'.")
        {
            PropertyId = propertyId;
            CurrentStatus = status;
        }
    }

}
