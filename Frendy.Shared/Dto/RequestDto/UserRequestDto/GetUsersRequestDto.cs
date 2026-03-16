using System.ComponentModel.DataAnnotations;
using Frendy.Shared.Enums;

namespace Frendy.Shared.Dto.RequestDto.UserRequestDto;

/// <summary>
/// Запрос на получение пользователя по Id или списка пользователей с пагинацией и фильтрами по датам
/// </summary>
public class GetUsersRequestDto
{
    /// <summary>
    /// Если указан, вернётся один пользователь с данным Id
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// Фильтр по дате регистрации: от
    /// </summary>
    public DateTime? RegistrationFrom { get; set; }

    /// <summary>
    /// Фильтр по дате регистрации: до
    /// </summary>
    public DateTime? RegistrationTo { get; set; }

    /// <summary>
    /// Фильтр по дате последней активности: от
    /// </summary>
    public DateTime? LastActivityFrom { get; set; }

    /// <summary>
    /// Фильтр по дате последней активности: до
    /// </summary>
    public DateTime? LastActivityTo { get; set; }

    /// <summary>
    /// Фильтр по дате рождения: от
    /// </summary>
    public DateTime? BirthDateFrom { get; set; }

    /// <summary>
    /// Фильтр по дате рождения: до
    /// </summary>
    public DateTime? BirthDateTo { get; set; }
    
    /// <summary>
    /// Фильтр по статусу "Онлайн"
    /// </summary>
    public bool? IsOnline { get; set; }
    
    /// <summary>
    /// Фильтр по статусу "Заблокирован"
    /// </summary>
    public bool? IsBanned { get; set; }
    
    /// <summary>
    /// Фильтр по приоритетному типу авторизации
    /// </summary>
    public AuthType? AuthType { get; set; }
    
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
