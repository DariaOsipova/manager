using Manager.ValueObjects.Validators;
using Manager.ValueObjects.Base;

namespace Manager.ValueObjects
{
    public class UserName(string name)
        : ValueObject<string>(new UserNameValidator(), name)
    {
    }
}
