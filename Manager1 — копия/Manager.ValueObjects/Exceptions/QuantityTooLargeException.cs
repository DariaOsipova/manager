using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class QuantityTooLargeException : ArgumentOutOfRangeException
    {
        public int Value { get; }
        public int Max { get; }

        public QuantityTooLargeException(int value, int max)
            : base(nameof(value), $"Quantity '{value}' exceeds the maximum allowed value of {max}.")
        {
            Value = value;
            Max = max;
        }
    }

}
