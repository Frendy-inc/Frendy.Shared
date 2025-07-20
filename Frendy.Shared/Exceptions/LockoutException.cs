namespace Frendy.Shared.Exceptions;

public class LockoutException : Exception
{
    public readonly string? Reason;
    public readonly DateTimeOffset? LockoutEnd;
    
    public LockoutException(string? message, string? reason, DateTimeOffset? lockoutEnd) : base(message)
    {
        Reason = reason;
        LockoutEnd = lockoutEnd;
    }
}