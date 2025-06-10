using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    /// <summary>
    /// Defines a method that implements the validation of the string.
    /// </summary>
    public class Description(string description)
        : ValueObject<string>(new DescriptionValidator(), description);

}
