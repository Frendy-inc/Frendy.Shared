namespace Frendy.Shared.Entities;

/// <summary>
/// Класс чата
/// </summary>
public class Chat
{
    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название чата
    /// </summary>
    public string Title { get; set; } = null!;
    /// <summary>
    /// Ссылка на аватар чата
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// Градиент аватара чата
    /// </summary>
    /// <remarks>Актуально, если аватар не установлен</remarks>
    public Gradient AvatarGradient { get; set; } = new(); 
    /// <summary>
    /// Флаг, отображающий, удален ли чат глобально
    /// </summary>
    public bool IsGlobalDeleted { get; set; }

    /// <summary>
    /// Список участников чата
    /// </summary>
    public List<User> Members { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов участников чата
    /// </summary>
    public List<UserChat> UserChats { get; set; } = new();
    
    /// <summary>
    /// Список сообщений чата
    /// </summary>
    public List<Message> Messages { get; set; } = new();
    
    /// <summary>
    /// Список встреч чата
    /// </summary>
    public List<Meeting> Meetings { get; set; } = new();
}