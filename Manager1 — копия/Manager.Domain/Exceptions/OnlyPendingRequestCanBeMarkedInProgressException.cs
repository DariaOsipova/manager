using Manager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class OnlyPendingRequestCanBeMarkedInProgressException : InvalidOperationException
    {
        public Guid RequestId { get; }
        public RequestStatus CurrentStatus { get; }

        public OnlyPendingRequestCanBeMarkedInProgressException(Guid requestId, RequestStatus currentStatus)
            : base($"Only pending requests can be marked in progress. Request '{requestId}' has status '{currentStatus}'.")
        {
            RequestId = requestId;
            CurrentStatus = currentStatus;
        }
    }

}
