using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class ContractNumberValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 30;
        public static int MIN_LENGTH => 3;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ContractNumberNullException(nameof(value));

            if (value.Length > MAX_LENGTH)
                throw new ContractNumberTooLongException(value, MAX_LENGTH);

            if (value.Length < MIN_LENGTH)
                throw new ContractNumberTooShortException(value, MIN_LENGTH);

            if (!value.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '/'))
                throw new ContractNumberInvalidCharactersException(value);
        }
    }
}
