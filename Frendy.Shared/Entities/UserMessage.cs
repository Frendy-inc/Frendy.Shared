namespace Frendy.Shared.Entities;

/// <summary>
/// Класс сообщений пользователя
/// </summary>
public class UserMessage
{
    /// <summary>
    /// Идентификатор сообщения
    /// </summary>
    public Guid MessageId { get; set; }
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Флаг, отображающий, удалено ли сообщение
    /// </summary>
    public bool IsDeleted { get; set; }
    /// <summary>
    /// Флаг, отображающий, закреплено ли сообщение
    /// </summary>
    public bool IsPinned { get; set; }
    
    /// <summary>
    /// Объект сообщения
    /// </summary>
    public Message Message { get; set; } = new();
    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
}