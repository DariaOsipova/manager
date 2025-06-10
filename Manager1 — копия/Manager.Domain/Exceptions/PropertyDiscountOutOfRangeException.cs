using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Domain.Exceptions
{
    public class PropertyDiscountOutOfRangeException : ArgumentOutOfRangeException
    {
        public decimal Discount { get; }

        public PropertyDiscountOutOfRangeException(decimal discount)
            : base(nameof(discount), $"Discount '{discount}%' must be between 0 and 100.")
        {
            Discount = discount;
        }
    }

}
