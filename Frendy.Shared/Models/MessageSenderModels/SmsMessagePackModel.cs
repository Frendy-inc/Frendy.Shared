namespace Frendy.Shared.Models.MessageSenderModels;

/// <summary>
/// Класс СМС сообщения
/// </summary>
public class SmsMessagePackModel : BaseMessagePackModel
{
    /// <summary>
    /// Имя отправителя
    /// </summary>
    public required string Sender { get; set; }
    
    /// <summary>
    /// Тэг сообщения
    /// </summary>
    public string? Tag { get; set; }
}