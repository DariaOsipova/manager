using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class RoomValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 10;
        public static int MIN_LENGTH => 1;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new RoomNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new RoomTooLongException(value, MAX_LENGTH);

            if (value.Length < MIN_LENGTH)
                throw new RoomTooShortException(value, MIN_LENGTH);

            if (!value.All(c => char.IsLetterOrDigit(c) || c == '-'))
                throw new RoomInvalidCharactersException(value);
        }
    }
}
