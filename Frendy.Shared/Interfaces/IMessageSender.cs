namespace Frendy.Shared.Interfaces;

/// <summary>
/// Интерфейс отправщика сообщений
/// </summary>
public interface IMessageSender
{
    /// <summary>
    /// Отправить СМС сообщение
    /// </summary>
    /// <param name="number">Номер телефона</param>
    /// <param name="message">Текст сообщения</param>
    Task SendSmsMessageAsync(string number, string message);
    
    /// <summary>
    /// Отправить Telegram сообщение
    /// </summary>
    /// <param name="number">Номер телефона</param>
    /// <param name="code">Код подтверждения</param>
    Task SendTelegramMessageAsync(string number, int code);
}