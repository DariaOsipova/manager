using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class NullException : ArgumentNullException
    {
        public string TargetName { get; }
        public string Details { get; }

        public NullException(string targetName, string details)
            : base(targetName, $"[{targetName}] is null. {details}")
        {
            TargetName = targetName;
            Details = details;
        }
    }

}
