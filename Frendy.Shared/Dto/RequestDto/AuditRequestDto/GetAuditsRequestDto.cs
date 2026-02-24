using System.ComponentModel.DataAnnotations;

namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Запрос на получение аудитов
/// </summary>
public class GetAuditsRequestDto
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
    
    /// <summary>
    /// С какого элемента необходимо получить
    /// </summary>
    public int From { get; set; }

    /// <summary>
    /// Номер страницы (начиная с 1)
    /// </summary>
    [Range(1, int.MaxValue)]
    public int Page { get; set; } = 1;

    /// <summary>
    /// Размер страницы
    /// </summary>
    [Range(1, 1000)]
    public int PageSize { get; set; } = 50;
    
    /// <summary>
    /// Строка для поиска (опционально)
    /// </summary>
    [StringLength(255)]
    public string? Search { get; set; } 
}
