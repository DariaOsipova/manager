using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class ContactInfoValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 100;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ContactInfoNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new ContactInfoTooLongException(value, MAX_LENGTH);

            if (!value.Any(char.IsLetterOrDigit))
                throw new ContactInfoInvalidFormatException(value);
        }
    }
}
