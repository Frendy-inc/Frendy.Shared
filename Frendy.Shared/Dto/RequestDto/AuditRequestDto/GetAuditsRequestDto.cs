namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Запрос на получение аудитов
/// </summary>
public class GetAuditsRequestDto : PagedRequestDto
{
    /// <summary>
    /// Фильтр по идентификатору аудита (опционально)
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Фильтр по идентификатору исполнителя (опционально)
    /// </summary>
    public Guid? ExecutorId { get; set; }

    /// <summary>
    /// Фильтр по идентификатору цели (опционально)
    /// </summary>
    public Guid? TargetId { get; set; }

    /// <summary>
    /// Фильтр по дате/времени: от (UTC, включительно)
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Фильтр по дате/времени: до (UTC, включительно)
    /// </summary>
    public DateTime? ToDate { get; set; }
}
