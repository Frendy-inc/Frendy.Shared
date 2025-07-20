using NpgsqlTypes;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс стикера
/// </summary>
public class Sticker
{
    /// <summary>
    /// Идентификатор стикера
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Ссылка на стикер
    /// </summary>
    public string Url { get; set; } = null!;
    /// <summary>
    /// Ключевые слова для поиска стикера
    /// </summary>
    public string KeyWords { get; set; } = null!;
    /// <summary>
    /// Вектор поиска
    /// </summary>
    public NpgsqlTsVector SearchVector { get; set; } = null!;
    /// <summary>
    /// Идентификатор набора
    /// </summary>
    public Guid StickerSetId { get; set; }
    /// <summary>
    /// Идентификатор уровня достижения, на котором открывается стикер
    /// </summary>
    public Guid AchievementLevelId { get; set; }

    /// <summary>
    /// Набор стикеров
    /// </summary>
    public StickerSet StickerSet { get; set; } = new();
    
    /// <summary>
    /// Список пользователей, которым доступен стикер
    /// </summary>
    public List<User> Users { get; set; } = new();    
    /// <summary>
    /// Список промежуточных объектов пользователей, которым доступен стикер
    /// </summary>
    public List<UserSticker> UserStickers { get; set; } = new();

    /// <summary>
    /// Уровень достижения, за которое открывается стикер
    /// </summary>
    public AchievementLevel AchievementLevel { get; set; } = new();
}