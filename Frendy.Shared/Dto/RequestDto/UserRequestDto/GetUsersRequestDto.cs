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
    /// Пагинация: номер страницы (начиная с 1)
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Пагинация: размер страницы
    /// </summary>
    public int PageSize { get; set; } = 20;

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
}
