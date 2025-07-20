using Frendy.Shared.Enums;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс друга пользователя
/// </summary>
public class UserFriend
{
    /// <summary>
    /// Идентификатор текущего пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор друга
    /// </summary>
    public Guid FriendId { get; set; }
    /// <summary>
    /// Флаг, показывающий, в бане ли друг у текущего пользователя
    /// </summary>
    public bool IsBanned { get; set; }
    /// <summary>
    /// Кастомное имя друга
    /// </summary>
    public string? CustomName { get; set; }
    /// <inheritdoc cref="FriendQueryStatus"/>
    public FriendQueryStatus Status { get; set; }

    /// <summary>
    /// Объект текущего пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект друга
    /// </summary>
    public User Friend { get; set; } = new();
}