namespace Frendy.Shared.Enums;

/// <summary>
/// Режим поиска пользователя
/// </summary>
public enum UserSearchMode
{
    /// <summary>
    /// По Email
    /// </summary>
    Email = 1,
    /// <summary>
    /// По номеру телефона
    /// </summary>
    PhoneNumber = 2,
    /// <summary>
    /// По логину
    /// </summary>
    UserName = 3
}

/// <summary>
/// Расширения для <see cref="UserSearchMode"/>
/// </summary>
public static class UserSearchModeExtensions
{
    /// <summary>
    /// Конвертировать в <see cref="AuthType"/>
    /// </summary>
    /// <param name="userSearchMode">Режим поиска пользователя</param>
    /// <returns><see cref="AuthType"/></returns>
    public static AuthType ToAuthType(this UserSearchMode userSearchMode)
    {
        switch (userSearchMode)
        {
            case UserSearchMode.Email:
                return AuthType.Email;
            case UserSearchMode.PhoneNumber:
                return AuthType.PhoneNumber;
            default:
                throw new ArgumentOutOfRangeException(nameof(userSearchMode), userSearchMode, null);
        }
    }
}