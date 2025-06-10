namespace Manager.Domain.Exceptions;

public class InvalidPriceException : DomainException
{
    public InvalidPriceException(string message) : base(message)
    {
    }
}