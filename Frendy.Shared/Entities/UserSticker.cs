namespace Frendy.Shared.Entities;

/// <summary>
/// Класс открытых пользователем стикеров
/// </summary>
public class UserSticker
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор стикера
    /// </summary>
    public Guid StickerId { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект стикера
    /// </summary>
    public Sticker Sticker { get; set; } = new();
}