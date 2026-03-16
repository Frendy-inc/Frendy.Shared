using Frendy.Shared.Dto.ResponseDto.UserResponseDto;
using Frendy.Shared.Entities;

namespace Frendy.Shared.Extensions;

/// <summary>
/// Расширения конвертации
/// </summary>
public static class ConvertExtension
{
    /// <summary>
    /// Получить имя перечисления
    /// </summary>
    /// <param name="inputEnum">Перечисление, имя которого нужно получить</param>
    /// <typeparam name="T">Тип перечисления</typeparam>
    /// <returns>Название перечисления</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string GetEnumName<T>(this T inputEnum) where T : Enum
    {
        var enumName = Enum.GetName(typeof(T), inputEnum);
        return enumName ?? throw new ArgumentException($"The value '{inputEnum}' not found in enum '{nameof(T)}'");
    }

    /// <summary>
    /// Получить дату в виде строки
    /// </summary>
    /// <param name="inputDate">Дата, которую нужно конвертировать</param>
    /// <param name="withTime">Нужно ли включить время в результат</param>
    /// <returns>Конвертированное в строку время</returns>
    public static string GetStringDate(this DateTime inputDate, bool withTime = false)
    {
        return inputDate.ToString(withTime ? "dd.MM.yyyy hh:mm" : "dd.MM.yyyy");
    }
    
    /// <summary>
    /// Конвертировать <see cref="User"/> в <see cref="GetUserInfoResponseLookup"/>
    /// </summary>
    /// <param name="user">Пользователь для конвертации</param>
    /// <returns><see cref="GetUserInfoResponseLookup"/></returns>
    public static GetUserInfoResponseLookup ToLookup(this User user)
    {
        return new GetUserInfoResponseLookup
        {
            Id = user.Id,
            FullName = user.FullName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            AvatarUrl = user.AvatarUrl,
            Birthday = user.Birthday,
            Role = user.Role,
            EmailConfirmed = user.EmailConfirmed,
            PhoneConfirmed = user.PhoneNumberConfirmed,
            IsLockedOut = user.LockoutEnabled,
            LockoutReason = user.LockoutReason
        };
    }
}