using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Number(string value)
        : ValueObject<string>(new NumberValidator(), value)
    {
    }
}

