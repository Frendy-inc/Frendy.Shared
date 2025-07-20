namespace Frendy.Shared.Entities;

/// <summary>
/// Класс набора стикеров
/// </summary>
public class StickerSet
{
    /// <summary>
    /// Идентификатор набора стикеров
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Название набора
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Описание набора
    /// </summary>
    public string Description { get; set; } = null!;
    /// <summary>
    /// Ссылка на обложку набора
    /// </summary>
    public string CoverUrl { get; set; } = null!;

    /// <summary>
    /// Список стикеров набора
    /// </summary>
    public List<Sticker> Stickers { get; set; } = new();

    /// <summary>
    /// Достижение, за которое можно получить набор стикеров
    /// </summary>
    public Achievement Achievement { get; set; } = new();
    
    /// <summary>
    /// Список пользователей, которым доступен набор стикеров
    /// </summary>
    public List<User> Users { get; set; } = new();    
    /// <summary>
    /// Список промежуточных объектов пользователей, которым доступен набор стикеров
    /// </summary>
    public List<UserStickerSet> UserStickerSets { get; set; } = new();
}