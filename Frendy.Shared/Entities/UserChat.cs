using Frendy.Shared.Enums;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс чата пользователя
/// </summary>
public class UserChat
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public Guid ChatId { get; set; }
    /// <summary>
    /// Роль текущего пользователя в чате
    /// </summary>
    public ChatRole Role { get; set; }
    /// <summary>
    /// Индекс (положение) чата в списке
    /// </summary>
    /// <remarks>
    /// Актуально если он закреплён
    /// </remarks>
    public byte Index { get; set; }
    /// <summary>
    /// Флаг закреплённости чата
    /// </summary>
    public bool IsPinned { get; set; }
    /// <summary>
    /// Флаг заглушенности чата
    /// </summary>
    public bool IsMuted { get; set; }
    /// <summary>
    /// Время истечения заглушенности
    /// </summary>
    public DateTime? Expires { get; set; }
    /// <summary>
    /// Флаг удалённого чата
    /// </summary>
    public bool IsCleaned { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект чата
    /// </summary>
    public Chat Chat { get; set; } = new();
}