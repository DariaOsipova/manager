using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Address(string address)
        : ValueObject<string>(new AddressValidator(), address)
    {
    }
}
