namespace Frendy.Shared.Entities;

/// <summary>
/// Класс устройства
/// </summary>
public class Device
{
    /// <summary>
    /// Идентификатор устройства пользователя
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Производитель устройства
    /// </summary>
    public string Manufacturer { get; set; } = null!;
    /// <summary>
    /// Модель устройства
    /// </summary>
    public string Model { get; set; } = null!;
    /// <summary>
    /// Операционная система
    /// </summary>
    public string OperationSystem { get; set; } = null!; 
    /// <summary>
    /// Флаг допустимости авторизации с устройства
    /// </summary>
    public bool IsAborted { get; set; }
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Последняя активность с устройства
    /// </summary>
    public DateTime LastActivity { get; set; }
    /// <summary>
    /// Id города последней активности
    /// </summary>
    public long PlaceId { get; set; }
    /// <summary>
    /// Токен обновления
    /// </summary>
    public string RefreshToken { get; set; } = null!;
    /// <summary>
    /// Время жизни токена доступа
    /// </summary>
    public DateTime RefreshTokenExpires { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
}