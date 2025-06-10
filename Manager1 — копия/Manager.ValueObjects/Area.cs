using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Area(string area)
        : ValueObject<string>(new AreaValidator(), area)
    {
    }
}
