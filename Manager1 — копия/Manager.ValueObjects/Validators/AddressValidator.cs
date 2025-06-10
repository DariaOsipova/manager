using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class AddressValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 200;
        public static int MIN_LENGTH => 5;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new AddressNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new AddressTooLongException(value, MAX_LENGTH);

            if (value.Length < MIN_LENGTH)
                throw new AddressTooShortException(value, MIN_LENGTH);

            if (value.Contains("  "))
                throw new AddressDoubleWhitespaceException(value);
        }
    }
}
