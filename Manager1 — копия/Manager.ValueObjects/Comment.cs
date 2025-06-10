using Manager.ValueObjects.Base;
using Manager.ValueObjects.Validators;

namespace Manager.ValueObjects
{
    public class Comment(string text)
        : ValueObject<string>(new CommentValidator(), text)
    {
    }
}
