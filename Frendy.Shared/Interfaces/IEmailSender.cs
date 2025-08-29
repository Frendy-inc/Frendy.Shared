namespace Frendy.Shared.Interfaces;

/// <summary>
/// Интерфейс отправщика сообщений
/// </summary>
public interface IEmailSender
{
    /// <summary>
    /// Отправить сообщение пользователю
    /// </summary>
    /// <param name="email">Адрес почты получателя</param>
    /// <param name="subject">Тема письма</param>
    /// <param name="htmlMessage">Текст сообщения</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Булевый результат отправки</returns>
    Task<bool> SendEmailAsync(string subject, string htmlMessage, string? email, CancellationToken cancellationToken = default);
}