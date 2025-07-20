using System.ComponentModel.DataAnnotations;
using Frendy.Shared.Exceptions;

namespace Frendy.Shared.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class NotBothNullAttribute : ValidationAttribute
{
    private readonly string _firstProperty;
    private readonly string _secondProperty;
    private readonly string? _errorMessage;

    public NotBothNullAttribute(string firstProperty, string secondProperty, string? errorMessage = null)
    {
        _firstProperty = firstProperty;
        _secondProperty = secondProperty;
        _errorMessage = errorMessage;
    }

    public override bool IsValid(object? value)
    {
        if (value is null) throw new ArgumentNullException(nameof(value), "Объект не может быть пустым");
        
        var type = value.GetType();

        var firstValue = type.GetProperty(_firstProperty)?.GetValue(value);
        var secondValue = type.GetProperty(_secondProperty)?.GetValue(value);

        if (firstValue == null && secondValue == null)
            throw new BadRequestException(_errorMessage);
        
        return true;
    }
}