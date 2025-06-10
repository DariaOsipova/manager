using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{

    public class Title(string title) 
        : ValueObject<string>(new TitleValidator(), title)
    {
    }
}