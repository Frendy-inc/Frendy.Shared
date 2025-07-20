namespace Frendy.Shared.Entities;

/// <summary>
/// Класс посещённого пользователем города
/// </summary>
public class UserCity
{
    /// <summary>
    /// Идентификатор записи
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор города
    /// </summary>
    public int PlaceId { get; set; }
    /// <summary>
    /// Пройденное расстояние
    /// </summary>
    public double Passes { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
}