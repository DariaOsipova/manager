using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class ApprovedRequestCannotBeRejectedException : InvalidOperationException
    {
        public Guid RequestId { get; }

        public ApprovedRequestCannotBeRejectedException(Guid requestId)
            : base($"Approved request '{requestId}' cannot be rejected.")
        {
            RequestId = requestId;
        }
    }

}
