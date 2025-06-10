using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class DealAlreadyPaidException : InvalidOperationException
    {
        public Guid DealId { get; }

        public DealAlreadyPaidException(Guid dealId)
            : base($"Deal '{dealId}' is already fully paid.")
        {
            DealId = dealId;
        }
    }

}
