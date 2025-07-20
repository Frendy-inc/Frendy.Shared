namespace Frendy.Shared.Entities;

/// <summary>
/// Класс уровня достижения
/// </summary>
public class AchievementLevel
{
    /// <summary>
    /// Идентификатор уровня достижения
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Описание уровня достижения
    /// </summary>
    public string Description { get; set; } = null!;
    /// <summary>
    /// Ссылка на иконку уровня достижения
    /// </summary>
    public string IconUrl { get; set; } = null!;
    /// <summary>
    /// Цель до получения следущего уровня
    /// </summary>
    public int Target { get; set; }
    /// <summary>
    /// Идентификатор достижения
    /// </summary>
    public Guid AchievementId { get; set; }

    /// <summary>
    /// Список объектов наград за уровень достижения
    /// </summary>
    /// <remarks>В качестве награды выступает стикер из стикерпака</remarks>
    public List<Sticker> Rewards { get; set; } = new();

    /// <summary>
    /// Объект достижения
    /// </summary>
    public Achievement Achievement { get; set; } = new();
    
    /// <summary>
    /// Прогресс пользователей в уровне достижения
    /// </summary>
    public List<User> Users { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов прогрессов пользователей в уровне достижения
    /// </summary>
    public List<UserAchievementLevel> UserAchievementLevels { get; set; } = new();
}