using System.ComponentModel.DataAnnotations;

namespace Frendy.Shared.Dto;

/// <summary>
/// Пагинированный запрос
/// </summary>
public class PagedRequestDto
{
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