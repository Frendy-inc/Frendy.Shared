using Frendy.Shared.Enums;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс сообщения
/// </summary>
public class Message
{
    /// <summary>
    /// Идентификатор сообщения
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Тип сообщения
    /// </summary>
    public MessageType Type { get; set; }
    /// <summary>
    /// Содержимое сообщения
    /// </summary>
    public string? Content { get; set; }
    /// <summary>
    /// Идентификатор отправителя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор сообщения-адресата
    /// </summary>
    public Guid? RecipientMessageId { get; set; }
    /// <summary>
    /// Дата отправки сообщения
    /// </summary>
    public DateTime Date { get; set; }
    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public Guid ChatId { get; set; }
    /// <summary>
    /// Флаг, отображающий, удалено ли сообщение глобально
    /// </summary>
    public bool IsGlobalDeleted { get; set; }

    /// <summary>
    /// Объект отправителя сообщения
    /// </summary>
    public User Sender { get; set; } = new();
    
    /// <summary>
    /// Объект сообщения, на которое в ответ было прислано текущее
    /// </summary>
    public Message RecipientMessage { get; set; } = new();
    /// <summary>
    /// Список ответных сообщений на текущее
    /// </summary>
    public List<Message> Answers { get; set; } = new();
    
    /// <summary>
    /// Объект чата
    /// </summary>
    public Chat Chat { get; set; } = new();
    
    /// <summary>
    /// Список пользователей, которые просмотрели сообщение
    /// </summary>
    public List<User> Viewers { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов пользователей, которые просмотрели сообщение
    /// </summary>
    public List<UserMessage> UserMessages { get; set; } = new();
}