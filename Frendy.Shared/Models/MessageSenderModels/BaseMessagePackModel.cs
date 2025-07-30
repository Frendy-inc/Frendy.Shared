using System.Text.Json.Serialization;

namespace Frendy.Shared.Models.MessageSenderModels;

/// <summary>
/// Базовый класс сообщения
/// </summary>
public class BaseMessagePackModel
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    public required string Phone { get; set; }
    
    /// <summary>
    /// Текст сообщения
    /// </summary>
    public required string Message { get; set; }
    
    /// <summary>
    /// Ссылка, встраиваемая в сообщение 
    /// </summary>
    public string? Link { get; set; }
    
    /// <summary>
    /// Домен для сообщения ссылки
    /// </summary>
    public string? Domain { get; set; }
    
    /// <summary>
    /// Срок жизни сообщения в минутах
    /// </summary>
    [JsonPropertyName("expired_after")]
    public string? ExpiredAfter { get; set; }
}