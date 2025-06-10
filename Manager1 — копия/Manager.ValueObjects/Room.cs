using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Room(string number)
        : ValueObject<string>(new RoomValidator(), number)
    {
    }
}
