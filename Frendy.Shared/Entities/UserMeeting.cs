namespace Frendy.Shared.Entities;

/// <summary>
/// Класс встреч пользователя
/// </summary>
public class UserMeeting
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор встречи
    /// </summary>
    public Guid MeetingId { get; set; }
    /// <summary>
    /// Начало встречи
    /// </summary>
    public DateTime StartTime { get; set; }
    /// <summary>
    /// Конец встречи
    /// </summary>
    public DateTime EndTime { get; set; }
    /// <summary>
    /// Список идентификаторов ФИАС (маршрут)
    /// </summary>
    public List<Guid> Route { get; set; } = new();
    
    /// <summary>
    /// Объект текущего пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект встречи
    /// </summary>
    public Meeting Meeting { get; set; } = new();
}