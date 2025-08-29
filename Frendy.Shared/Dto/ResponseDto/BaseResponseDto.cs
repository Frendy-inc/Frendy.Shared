namespace Frendy.Shared.Dto.ResponseDto;

/// <summary>
/// Базовый объект для объекта запроса
/// </summary>
public class BaseResponseDto
{
    /// <summary>
    /// Ссылка возврата
    /// </summary>
    /// <remarks>
    /// По ней будет перенаправлен пользователь после завершения действия
    /// </remarks>
    public string? ReturnUrl { get; set; }
}