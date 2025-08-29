namespace Frendy.Shared.Entities;

/// <summary>
/// Класс действия аудита
/// </summary>
public class Action
{
    /// <summary>
    /// Идентификатор действия аудита
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название действия на русском языке
    /// </summary>
    public string NameRu { get; set; } = null!;
    
    /// <summary>
    /// Название действия на английском языке
    /// </summary>
    public string NameEn { get; set; } = null!;
    
    /// <summary>
    /// Список аудитов
    /// </summary>
    public List<Audit>? Audits { get; set; }
}