namespace Frendy.Shared.Entities;

/// <summary>
/// Класс прогресса пользователя в достижении
/// </summary>
public class UserAchievement
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор достижения
    /// </summary>
    public Guid AchievementId { get; set; }
    /// <summary>
    /// Флаг завершённости достижения
    /// </summary>
    public bool IsCompleted { get; set; }

    /// <summary>
    /// Объект достижения
    /// </summary>
    public Achievement Achievement { get; set; } = new();
    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
}