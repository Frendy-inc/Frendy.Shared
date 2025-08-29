namespace Frendy.Shared.Dto.ResponseDto.AuthResponseDto;

/// <summary>
/// Объект ответа от метода сброса пароля
/// </summary>
public class PasswordResetResponseDto
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Токен для сброса пароля
    /// </summary>
    public string Token { get; set; } = string.Empty;
}