namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// DTO для запроса обновления access токена по refresh токену
/// </summary>
public class RefreshTokenRequestDto
{
    /// <summary>
    /// Токен доступа
    /// </summary>
    public string AccessToken { get; set; } = null!;
    
    /// <summary>
    /// Refresh токен
    /// </summary>
    public string RefreshToken { get; set; } = null!;
    
}