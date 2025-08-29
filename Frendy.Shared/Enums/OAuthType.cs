namespace Frendy.Shared.Enums;

/// <summary>
/// Перечисление типов авторизации
/// </summary>
public enum OAuthType
{
    /// <summary>
    /// Через ВКонтакте
    /// </summary>
    Vk = 1,
    /// <summary>
    /// Через Яндекс
    /// </summary>
    Yandex = 2
}

/// <summary>
/// Расширения для перечисления типов авторизации
/// </summary>
public static class OAuthTypeExtensions
{
    /// <summary>
    /// Конвертировать <see cref="OAuthType"/> в <see cref="AuthType"/>
    /// </summary>
    /// <param name="oAuthType">Тип OAuth</param>
    /// <returns></returns>
    public static AuthType ToAuthType(this OAuthType oAuthType)
    {
        return oAuthType switch
        {
            OAuthType.Vk => AuthType.Vk,
            OAuthType.Yandex => AuthType.Yandex,
            _ => throw new ArgumentOutOfRangeException(nameof(oAuthType), oAuthType, null)
        };
    }
}