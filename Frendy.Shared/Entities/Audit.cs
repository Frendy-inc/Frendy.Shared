using Frendy.Shared.Enums;

namespace Frendy.Shared.Entities;

/// <summary>
/// Класс аудита
/// </summary>
public class Audit
{
    /// <summary>
    /// Идентификатор аудита
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Идентификатор исполнителя действия
    /// </summary>
    public Guid ExecutorId { get; set; }
    
    /// <summary>
    /// Роль исполнителя действия
    /// </summary>
    public UserRole ExecutorRole { get; set; }
    
    /// <summary>
    /// Идентификатор цели действия
    /// </summary>
    public Guid TargetId { get; set; }
    
    /// <summary>
    /// Роль цели действия 
    /// </summary>
    public UserRole TargetRole { get; set; }
    
    /// <summary>
    /// Время действия
    /// </summary>
    public DateTime TimeOfAction { get; set; }
    
    /// <summary>
    /// Идентификатор действия
    /// </summary>
    public int ActionId { get; set; }

    /// <summary>
    /// Класс исполнителя аудита
    /// </summary>
    public User Executor { get; set; } = null!;
    
    /// <summary>
    /// Класс цели аудита
    /// </summary>
    public User Target { get; set; } = null!;
    
    /// <summary>
    /// Класс действия аудита
    /// </summary>
    public Action Action { get; set; } = null!;
}