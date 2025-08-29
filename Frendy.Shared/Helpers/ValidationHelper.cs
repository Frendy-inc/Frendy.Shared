using System.Text.RegularExpressions;
using Frendy.Shared.Dto;
using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Helpers;

public static class ValidationHelper
{
    /// <summary>
    /// Провести валидацию <see cref="UserSearchModel"/>
    /// </summary>
    /// <param name="dto">Валидируемый объект</param>
    /// <param name="localizationService">Сервис локализации</param>
    /// <returns>Результат валидации</returns>
    public static ValidationResult Validate(this UserSearchModel dto, ILocalizationService localizationService)
    {
        var errors = new List<string>();

        switch (dto.SearchMode)
        {
            case UserSearchMode.Email:
            {
                if (!ValidateEmail(dto.SearchValue))
                    errors.Add(localizationService.GetString("IncorrectEmailFormat"));
                break;
            }
            case UserSearchMode.PhoneNumber:
            {
                if (!ValidatePhoneNumber(dto.SearchValue))
                    errors.Add(localizationService.GetString("IncorrectPhoneNumberFormat"));
                break;
            }
            case UserSearchMode.UserName:
                break;
            default:
                localizationService.GetString("UnknownUserSearchModeFormat");
                break;
        }

        return BuildValidationResult(errors);
    }

    internal static bool ValidateEmail(string email)
    {
        var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        return !email.IsNullOrEmpty() && regex.IsMatch(email);
    }

    internal static bool ValidatePhoneNumber(string phoneNumber)
    {
        var regex = new Regex(@"^\+?[0-9]{9,15}$");
        return !phoneNumber.IsNullOrEmpty() && regex.IsMatch(phoneNumber);
    }

    internal static bool ValidateIpAddress(string ipAddress)
    {
        var regex = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        return !ipAddress.IsNullOrEmpty() && regex.IsMatch(ipAddress);
    }

    internal static bool ValidatePassword(string password)
    {
        var regex = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d!@#$%^*()_+-=;':,.?~]{8,32}$");
        return !password.IsNullOrEmpty() && regex.IsMatch(password);
    }

    internal static bool ValidateCode(string code)
    {
        var regex = new Regex(@"^\d{6}$");
        return !code.IsNullOrEmpty() && regex.IsMatch(code);
    }

    public static ValidationResult BuildValidationResult(List<string>? errors)
    {
        if (errors is not null && errors.Count > 0)
            return new ValidationResult
            {
                Status = ValidationStatus.Error,
                Errors = errors
            };
        
        return new ValidationResult { Status = ValidationStatus.Success};
    }
}