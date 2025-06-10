using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class ContactInfo(string info)
        : ValueObject<string>(new ContactInfoValidator(), info)
    {
    }
}
