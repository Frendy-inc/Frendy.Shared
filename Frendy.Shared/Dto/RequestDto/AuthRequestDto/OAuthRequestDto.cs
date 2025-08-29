using Frendy.Shared.Enums;
using Frendy.Shared.Extensions;
using Frendy.Shared.Helpers;
using Frendy.Shared.Interfaces;
using ValidationResult = Frendy.Shared.Models.ValidationResult;

namespace Frendy.Shared.Dto.RequestDto.AuthRequestDto;

/// <summary>
/// Объект запроса на OAuth авторизацию
/// </summary>
public class OAuthRequestDto : BaseRequestDto
{
    /// <summary>
    /// Тип OAuth авторизации
    /// </summary>
    public OAuthType OAuthType { get; set; }
    
    /// <summary>
    /// Токен доступа OAuth сервиса
    /// </summary>
    public string AccessToken { get; set; }
    
    
    public override ValidationResult Validate(ILocalizationService localizationService)
    {
        var errors = new List<string>();
        
        if ( AccessToken.IsNullOrEmpty())
            errors.Add(localizationService.GetString("IncorrectOAuthAccessToken"));
        
        var baseValidationResult = base.Validate(localizationService);
        if (baseValidationResult is { Status: ValidationStatus.Error, Errors.Count: > 0 })
            errors.AddRange(baseValidationResult.Errors);
            
        return ValidationHelper.BuildValidationResult(errors);
    }
}