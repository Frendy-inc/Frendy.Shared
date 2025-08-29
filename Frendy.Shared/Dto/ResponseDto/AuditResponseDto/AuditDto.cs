using Frendy.Shared.Enums;

namespace Frendy.Shared.Dto.ResponseDto.AuditResponseDto;

/// <summary>
/// DTO записи аудита
/// </summary>
public class AuditDto
{
    public Guid Id { get; set; }
    public Guid ExecutorId { get; set; }
    public UserRole ExecutorRole { get; set; }
    public Guid TargetId { get; set; }
    public UserRole TargetRole { get; set; }
    public DateTime TimeOfAction { get; set; }
    public int ActionId { get; set; }
}
