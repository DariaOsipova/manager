using Manager.ValueObjects.Base;
using Manager.ValueObjects.Exceptions;

namespace Manager.ValueObjects.Validators
{
    public class DescriptionValidator : IValidator<string>
    {
        /// <summary>
        /// Verifies the string to make sure it is not null, empty or doesn't consists only white-space characters. 
        /// </summary>
        /// <param name="value">A string containing data.</param>
        /// <exception cref="ArgumentNullOrWhiteSpaceException"></exception>
        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(nameof(value));
        }

    }
}
