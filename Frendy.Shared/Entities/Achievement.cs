namespace Frendy.Shared.Entities;

/// <summary>
/// Класс достижения
/// </summary>
public class Achievement
{
    /// <summary>
    /// Идентификатор достижения
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Идентификатор награды за достижение
    /// </summary>
    /// <remarks>В качестве награды выступает стикерпак</remarks>
    public Guid RewardId { get; set; }

    /// <summary>
    /// Объект награды за достижение
    /// </summary>
    /// <remarks>В качестве награды выступает стикерпак</remarks>
    public StickerSet Reward { get; set; } = new();

    /// <summary>
    /// Список уровней достижения
    /// </summary>
    public List<AchievementLevel> Levels { get; set; } = new();
    
    /// <summary>
    /// Прогресс пользователей в достижении
    /// </summary>
    public List<User> Users { get; set; } = new();
    /// <summary>
    /// Список промежуточных объектов прогрессов пользователей в достижении
    /// </summary>
    public List<UserAchievement> UserAchievements { get; set; } = new();
}