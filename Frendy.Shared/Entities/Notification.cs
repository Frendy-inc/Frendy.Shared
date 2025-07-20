using Frendy.Shared.Enums;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс уведомления
/// </summary>
public class Notification
{
    public Guid Id { get; set; }
    /// <summary>
    /// Тип уведомления
    /// </summary>
    public NotificationType NotificationType { get; set; }
    public bool IsViewed { get; set; }
    public bool IsCommon { get; set; }
    public string Message { get; set; } = null!;
    public DateTime PublicationDate { get; set; }
    public Guid? UserId { get; set; }
    
    public User? User { get; set; }
}