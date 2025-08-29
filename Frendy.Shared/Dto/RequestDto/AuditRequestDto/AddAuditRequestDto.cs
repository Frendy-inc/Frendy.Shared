namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Dto для добавления аудита
/// </summary>
public class AddAuditRequestDto
{
    /// <summary>
    /// Идентификатор исполнителя действия
    /// </summary>
    public Guid ExecutorId { get; set; }
    
    /// <summary>
    /// Идентификатор цели действия
    /// </summary>
    public Guid TargetId { get; set; }
    
    /// <summary>
    /// Идентификатор действия
    /// </summary>
    public int ActionId { get; set; }
}