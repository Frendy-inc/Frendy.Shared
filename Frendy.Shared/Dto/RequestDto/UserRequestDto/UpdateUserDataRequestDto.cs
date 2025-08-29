using Frendy.Shared.Entities;

namespace Frendy.Shared.Dto.RequestDto.UserRequestDto;

/// <summary>
/// Dto для запроса на обновление данных пользователя
/// </summary>
public class UpdateUserDataRequestDto
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string FirstName { get; set; } = null!;
    
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string LastName { get; set; } = null!;
    
    /// <summary>
    /// Почта пользователя
    /// </summary>
    public string? Email { get; set; }
    
    /// <summary>
    /// Номер телефона пользователя
    /// </summary>
    public string? PhoneNumber { get; set; }
    
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string UserName { get; set; } = null!;
    
    /// <summary>
    /// Дата рождения пользователя
    /// </summary>
    public DateTime Birthday { get; set; }
}

/// <summary>
/// Класс расширения для <see cref="UpdateUserDataRequestDto"/>
/// </summary>
public static class UpdateUserDataRequestDtoExtensions
{
    /// <summary>
    /// Преобразовать Dto в сущность пользователя
    /// </summary>
    /// <param name="dto">Dto для обновления данных пользователя</param>
    /// <param name="user">Пользователь для обновления</param>
    /// <returns>Сущность пользователя</returns>
    public static User ToUserEntity(this UpdateUserDataRequestDto dto, User user)
    {
        user.Id = dto.UserId;
        user.FirstName = dto.FirstName;
        user.LastName = dto.LastName;
        user.Email = dto.Email;
        user.PhoneNumber = dto.PhoneNumber;
        user.UserName = dto.UserName;
        user.Birthday = dto.Birthday;
        
        return user;
    }
}