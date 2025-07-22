namespace Frendy.Shared.Models.NatsModels;

/// <summary>
/// Модель Nats для блокировки пользователя
/// </summary>
public class NatsLockedOutModel
{
    /// <summary>
    /// Инициализация модели
    /// </summary>
    /// <param name="reason">Причина блокировки</param>
    /// <param name="lockedOutEnd">Время окончания блокировки</param>
    /// <param name="supportUrl">Ссылка на поддержку</param>
    public NatsLockedOutModel(string reason, DateTimeOffset? lockedOutEnd, string supportUrl)
    {
        Reason = reason;
        LockedOutEnd = lockedOutEnd;
        SupportUrl = supportUrl;
    }

    /// <summary>
    /// Причина блокировки
    /// </summary>
    public string Reason { get; set; }
    
    /// <summary>
    /// Дата окончания блокировки
    /// </summary>
    public DateTimeOffset? LockedOutEnd { get; set; }
    
    /// <summary>
    /// Ссылка на поддержку
    /// </summary>
    public string SupportUrl { get; set; }
}