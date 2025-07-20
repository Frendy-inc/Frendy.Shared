namespace Frendy.Shared.Exceptions;

/// <summary>
/// Доступ запрещён
/// </summary>
public class ForbiddenException : Exception
{
    public ForbiddenException(string message) : base(message) {}
}