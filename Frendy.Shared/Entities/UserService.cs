namespace Frendy.Shared.Entities;

/// <summary>
/// Класс использованных пользователем сервисов
/// </summary>
public class UserService
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор сервиса
    /// </summary>
    public Guid ServiceId { get; set; }
    /// <summary>
    /// Флаг, показывающий, закреплён сервис или нет
    /// </summary>
    public bool IsPinned { get; set; }
    /// <summary>
    /// Дата последней активности
    /// </summary>
    public DateTime? LastActivity { get; set; }
    /// <summary>
    /// Количество использований
    /// </summary>
    public int UsesCount { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект сервиса
    /// </summary>
    public Service Service { get; set; } = new();
}