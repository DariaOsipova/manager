using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class TitleValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 100;
        public static int MIN_LENGTH => 3;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new TitleNullException(nameof(value));

            if (value.Length < MIN_LENGTH)
                throw new TitleTooShortException(value, MIN_LENGTH);

            if (value.Length > MAX_LENGTH)
                throw new TitleTooLongException(value, MAX_LENGTH);
        }
    }
}