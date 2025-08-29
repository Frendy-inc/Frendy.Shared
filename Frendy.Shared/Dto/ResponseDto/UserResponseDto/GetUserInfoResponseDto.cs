using Frendy.Shared.Entities;
using Frendy.Shared.Enums;

namespace Frendy.Shared.Dto.ResponseDto.UserResponseDto;

/// <summary>
/// Объект ответа от метода получения пользователей
/// </summary>
public class GetUserInfoResponseDto
{
    /// <summary>
    /// Список пользователей
    /// </summary>
    public List<GetUserInfoResponseLookup> Users { get; set; } = new();
}

/// <summary>
/// Объект информации о конкретном пользователе
/// </summary>
public class GetUserInfoResponseLookup
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? Birthday { get; set; }
    public UserRole Role { get; set; }
    public bool EmailConfirmed { get; set; }
    public bool PhoneConfirmed { get; set; }
    public bool IsLockedOut { get; set; }
    public string? LockoutReason { get; set; }
}