namespace Frendy.Shared.Dto.ResponseDto.AuthResponseDto;

/// <summary>
/// Объект ответа от метода авторизации
/// </summary>
public class AuthorizeResponseDto : BaseResponseDto
{
    /// <summary>
    /// Новый access токен
    /// </summary>
    public string AccessToken { get; set; } = null!;

    /// <summary>
    /// Время истечения access токена
    /// </summary>
    public DateTime AccessTokenExpires { get; set; }

    /// <summary>
    /// Новый refresh токен
    /// </summary>
    public string? RefreshToken { get; set; }

    /// <summary>
    /// Время истечения refresh токена
    /// </summary>
    public long? RefreshTokenExpires { get; set; }
}