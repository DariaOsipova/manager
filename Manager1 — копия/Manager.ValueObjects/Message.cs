using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Message(string text)
        : ValueObject<string>(new MessageValidator(), text)
    {
    }
}

