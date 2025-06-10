using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Quantity(int value)
        : ValueObject<int>(new QuantityValidator(), value)
    {
    }
}

