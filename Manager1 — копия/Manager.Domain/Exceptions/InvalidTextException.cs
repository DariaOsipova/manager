namespace Manager.Domain.Exceptions;

public class InvalidTextException : DomainException
{
    public InvalidTextException(string message) : base(message)
    {
    }
}