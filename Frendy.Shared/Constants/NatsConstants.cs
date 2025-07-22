namespace Frendy.Shared.Constants;

/// <summary>
/// Константы Nats
/// </summary>
public static class NatsConstants
{
    /// <summary>
    /// Авторизация пользователя
    /// </summary>
    public const string LoggedInTopic = "LoggedIn";
    
    /// <summary>
    /// Блокировка пользователя
    /// </summary>
    public const string LockedOutTopic = "LockedOut";
}