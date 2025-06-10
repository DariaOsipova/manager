using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class CommentValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 500;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new CommentNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new CommentTooLongException(value, MAX_LENGTH);
        }
    }
}
