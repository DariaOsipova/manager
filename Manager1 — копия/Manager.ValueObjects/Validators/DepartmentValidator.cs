using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class DepartmentValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 100;
        public static int MIN_LENGTH => 2;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new DepartmentNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new DepartmentTooLongException(value, MAX_LENGTH);

            if (value.Length < MIN_LENGTH)
                throw new DepartmentTooShortException(value, MIN_LENGTH);

            if (value.Any(c => !(char.IsLetter(c) || char.IsWhiteSpace(c))))
                throw new DepartmentInvalidCharactersException(value);

            if (value.Contains("  "))
                throw new DepartmentDoubleWhitespaceException(value);
        }
    }
}
