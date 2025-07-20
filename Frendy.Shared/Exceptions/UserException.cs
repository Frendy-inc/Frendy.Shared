namespace Frendy.Shared.Exceptions;

/// <summary>
/// Исключение пользователя
/// </summary>
public class UserException : Exception
{
    public UserException(string message) : base(message) {}
}