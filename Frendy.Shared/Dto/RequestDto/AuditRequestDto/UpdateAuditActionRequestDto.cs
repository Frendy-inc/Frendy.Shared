namespace Frendy.Shared.Dto.RequestDto.AuditRequestDto;

/// <summary>
/// Dto для обновления действия аудита
/// </summary>
public class UpdateAuditActionRequestDto : AddAuditActionRequestDto
{
    /// <summary>
    /// Идентификатор действия
    /// </summary>
    public int Id { get; set; }
}