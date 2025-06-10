using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class MessageValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 1000;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new MessageNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new MessageTooLongException(value, MAX_LENGTH);
        }
    }
}

