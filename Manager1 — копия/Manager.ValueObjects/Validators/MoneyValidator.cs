using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    /// <summary>
    /// Defines a method that implements the validation of the decimal.
    /// </summary>
    public class MoneyValidator : IValidator<decimal>
    {
        /// <summary>
        /// Verifies that the decimal is not negative and does not equal zero. 
        /// </summary>
        /// <param name="value">A decimal value.</param>
        /// <exception cref="ArgumentNullOrWhiteSpaceException"></exception>
        public void Validate(decimal value)
        {
            if (value <= 0)
                throw new MoneyAmountNonPositiveException( nameof(value), value);
            if (!IsValidAmount(value))
                throw new MoneyAmountHasMoreThanTwoDecimalPlacesException(nameof(value), value);
        }

        private bool IsValidAmount(decimal value)
        {
            value = value * 100;
            value -= (int)value;
            return value == 0m;
        }
    }
}
