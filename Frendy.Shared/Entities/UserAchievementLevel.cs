namespace Frendy.Shared.Entities;

/// <summary>
/// Класс прогресса пользователя на уровне достижения
/// </summary>
public class UserAchievementLevel
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор уровня достижения
    /// </summary>
    public Guid AchievementLevelId { get; set; }
    /// <summary>
    /// Прогресс уровня
    /// </summary>
    public int Progress { get; set; }
    /// <summary>
    /// Флаг завершённости уровня достижения
    /// </summary>
    public bool IsCompleted { get; set; }

    /// <summary>
    /// Объект пользователя
    /// </summary>
    public User User { get; set; } = new();
    /// <summary>
    /// Объект уровня достижения
    /// </summary>
    public AchievementLevel AchievementLevel { get; set; } = new();
}