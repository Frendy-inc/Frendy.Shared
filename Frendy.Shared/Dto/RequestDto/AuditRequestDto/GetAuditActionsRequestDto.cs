namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Запрос на получение действий аудита
/// </summary>
public class GetAuditActionsRequestDto
{
    /// <summary>
    /// Фильтр по идентификатору действия (опционально)
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Номер страницы (начиная с 1)
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Размер страницы
    /// </summary>
    public int PageSize { get; set; } = 50;
}
