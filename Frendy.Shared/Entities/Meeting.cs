namespace Frendy.Shared.Entities;

/// <summary>
/// Класс встречи
/// </summary>
public class Meeting
{
    /// <summary>
    /// Идентификатор встречи
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public Guid ChatId { get; set; }

    /// <summary>
    /// Объект чата встречи
    /// </summary>
    public Chat Chat { get; set; } = new();

    /// <summary>
    /// Список встреч пользователя
    /// </summary>
    public List<User> Members { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов встреч пользователя
    /// </summary>
    public List<UserMeeting> UserMembers { get; set; } = new();
}