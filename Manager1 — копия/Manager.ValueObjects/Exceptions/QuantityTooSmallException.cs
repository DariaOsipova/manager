using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.ValueObjects.Exceptions
{
    public class QuantityTooSmallException : ArgumentOutOfRangeException
    {
        public int Value { get; }
        public int Min { get; }

        public QuantityTooSmallException(int value, int min)
            : base(nameof(value), $"Quantity '{value}' is below the minimum allowed value of {min}.")
        {
            Value = value;
            Min = min;
        }
    }

}
