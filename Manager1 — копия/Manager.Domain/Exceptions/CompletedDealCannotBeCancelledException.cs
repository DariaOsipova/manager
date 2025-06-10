using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class CompletedDealCannotBeCancelledException : InvalidOperationException
    {
        public Guid DealId { get; }

        public CompletedDealCannotBeCancelledException(Guid dealId)
            : base($"Completed deal '{dealId}' cannot be cancelled.")
        {
            DealId = dealId;
        }
    }

}
