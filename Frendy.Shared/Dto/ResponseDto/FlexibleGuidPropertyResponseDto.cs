using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frendy.Shared.Dto.ResponseDto;

/// <summary>
/// Dto ответа с динамическим названием свойства с типом Guid
/// </summary>
[JsonConverter(typeof(FlexibleGuidPropertyConverter))]
public class FlexibleGuidPropertyResponseDto : BaseResponseDto
{
    public Guid Value { get; }
    public string PropertyName { get; }

    public FlexibleGuidPropertyResponseDto(Guid value, string propertyName = "GuidProperty")
    {
        Value = value;
        PropertyName = propertyName;
    }
}

/// <summary>
/// Кастомный конвертер класса <see cref="FlexibleGuidPropertyResponseDto"/>
/// </summary>
public class FlexibleGuidPropertyConverter : JsonConverter<FlexibleGuidPropertyResponseDto>
{
    public override FlexibleGuidPropertyResponseDto Read(ref Utf8JsonReader reader, Type typeToConvert, 
        JsonSerializerOptions options)
    {
        throw new NotImplementedException("Deserialization is not supported for dynamic properties");
    }

    public override void Write(Utf8JsonWriter writer, FlexibleGuidPropertyResponseDto value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        writer.WritePropertyName(value.PropertyName);
        writer.WriteStringValue(value.Value);
        
        if (!string.IsNullOrEmpty(value.ReturnUrl))
        {
            writer.WritePropertyName("ReturnUrl");
            writer.WriteStringValue(value.ReturnUrl);
        }
        
        writer.WriteEndObject();
    }
}