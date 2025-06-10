using Manager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class RequestCannotBeApprovedInCurrentStateException : InvalidOperationException
    {
        public Guid RequestId { get; }
        public RequestStatus Status { get; }

        public RequestCannotBeApprovedInCurrentStateException(Guid requestId, RequestStatus status)
            : base($"Request '{requestId}' cannot be approved in current state: {status}.")
        {
            RequestId = requestId;
            Status = status;
        }
    }

}
