namespace Frendy.Shared.Models.MessageSenderModels;

/// <summary>
/// Базовый класс
/// </summary>
public class BaseMessageModel
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public required string Id { get; set; }
    
    /// <summary>
    /// Ключ к API
    /// </summary>
    public required string Password { get; set; }
}