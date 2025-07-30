namespace Frendy.Shared.Models.MessageSenderModels;

/// <summary>
/// Модель Telegram сообщения
/// </summary>
public class TelegramMessageModel : BaseMessageModel
{
    /// <summary>
    /// Массив сообщений
    /// </summary>
    public required List<TelegramMessagePackModel> Pack { get; set; }
}