using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class AreaValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 100;
        public static int MIN_LENGTH => 2;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new AreaNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new AreaTooLongException(value, MAX_LENGTH);

            if (value.Length < MIN_LENGTH)
                throw new AreaTooShortException(value, MIN_LENGTH);

            if (value.Any(c => !(char.IsLetter(c) || char.IsWhiteSpace(c))))
                throw new AreaInvalidCharactersException(value);

            if (value.Contains("  "))
                throw new AreaDoubleWhitespaceException(value);
        }
    }
}
