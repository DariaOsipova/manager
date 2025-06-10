using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class QuantityValidator : IValidator<int>
    {
        public static int MIN => 1;
        public static int MAX => 10_000;

        public void Validate(int value)
        {
            if (value < MIN)
                throw new QuantityTooSmallException(value, MIN);

            if (value > MAX)
                throw new QuantityTooLargeException(value, MAX);
        }
    }
}
