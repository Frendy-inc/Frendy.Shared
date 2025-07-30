namespace Frendy.Shared.Models.MessageSenderModels;

/// <summary>
/// Модель СМС сообщения
/// </summary>
public class SmsMessageModel : BaseMessageModel
{
    /// <summary>
    /// Массив сообщений
    /// </summary>
    public required List<SmsMessagePackModel> Pack { get; set; }
}