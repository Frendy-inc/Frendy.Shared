using Frendy.Shared.Enums;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using Frendy.Shared.Models;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на авторизацию
/// </summary>
public class AuthorizeRequestDto : UserSearchRequestDto
{
    public required string Credential { get; set; }
    
    /// <summary>
    /// Флаг, показывающий, нужен ли токен обновления
    /// </summary>
    public bool RefreshTokenRequired { get; set; }

    /// <summary>
    /// Флаг, показывающий, является ли авторизация через OAuth 
    /// </summary>
    public bool IsOAuth { get; set; }
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();

        var userValidationResult = UserSearch.Validate(localizationService);
        
        if (userValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(userValidationResult.Errors);
        
        if (!ValidationHelper.ValidateIpAddress(DeviceInfo.IpAddress))
            errors.Add(localizationService.GetString("IncorrectIpAddress"));
        
        if (UserSearch.SearchMode != UserSearchMode.PhoneNumber && !IsOAuth 
                && !ValidationHelper.ValidatePassword(Credential))
            errors.Add(localizationService.GetString("IncorrectPassword"));
        
        if (UserSearch.SearchMode == UserSearchMode.PhoneNumber && !ValidationHelper.ValidateCode(Credential))
            errors.Add(localizationService.GetString("IncorrectCode"));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
        
        return ValidationHelper.BuildValidationResult(errors);
    }
}