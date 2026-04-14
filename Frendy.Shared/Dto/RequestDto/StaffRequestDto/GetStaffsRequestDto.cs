namespace Frendy.Shared.Dto.RequestDto.StaffRequestDto;

/// <summary>
/// Запрос на получение пользователя по Id или персонала с пагинацией и фильтрами по датам
/// </summary>
public class GetStaffsRequestDto : PagedRequestDto
{
    /// <summary>
    /// Если указан, вернётся один пользователь с данным Id
    /// </summary>
    public Guid? StaffId { get; set; }

    /// <summary>
    /// Фильтр по дате последней активности: от
    /// </summary>
    public DateTime? LastActivityFrom { get; set; }

    /// <summary>
    /// Фильтр по дате последней активности: до
    /// </summary>
    public DateTime? LastActivityTo { get; set; }
    
    /// <summary>
    /// Фильтр по статусу "Онлайн"
    /// </summary>
    public bool? IsOnline { get; set; }
    
    /// <summary>
    /// Фильтр по назначившему роль
    /// </summary>
    public Guid? AssignerId { get; set; }
    
    /// <summary>
    /// Фильтр по дате назначения: от
    /// </summary>
    public DateTime? AssignDateFrom { get; set; }
    
    /// <summary>
    /// Фильтр по дате назначения: до
    /// </summary>
    public DateTime? AssignDateTo { get; set; }
}