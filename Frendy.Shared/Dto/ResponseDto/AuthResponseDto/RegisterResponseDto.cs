using Frendy.Shared.Enums;

namespace Frendy.Shared.Dto.ResponseDto.AuthResponseDto;

/// <summary>
/// Объект ответа от метода регистрации
/// </summary>
public class RegisterResponseDto : BaseResponseDto
{
    public Guid UserId { get; set; }
    /// <summary>
    /// Тип регистрации, по которому был зарегистрирован пользователь
    /// </summary>
    public AuthType AuthType { get; set; }
}