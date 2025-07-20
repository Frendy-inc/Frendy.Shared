namespace Frendy.Shared.Entities;

/// <summary>
/// Класс полученных пользователем ноборов стикеров
/// </summary>
public class UserStickerSet
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор набора стикеров
    /// </summary>
    public Guid StickerSetId { get; set; }

    /// <summary>
    /// Класс пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Набор стикеров
    /// </summary>
    public StickerSet StickerSet { get; set; } = new();
}