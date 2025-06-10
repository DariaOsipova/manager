using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class NumberValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 15;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NumberNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new NumberTooLongException(value, MAX_LENGTH);

            if (!value.All(char.IsDigit))
                throw new NumberInvalidCharactersException(value);
        }
    }
}

