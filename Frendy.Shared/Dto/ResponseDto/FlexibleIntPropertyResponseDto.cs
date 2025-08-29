using System.Text.Json;
using System.Text.Json.Serialization;

namespace Frendy.Shared.Dto.ResponseDto;

/// <summary>
/// Dto ответа с динамическим названием свойства с типом Int
/// </summary>
[JsonConverter(typeof(FlexibleIntPropertyConverter))]
public class FlexibleIntPropertyResponseDto : BaseResponseDto
{
    public int Value { get; }
    public string PropertyName { get; }

    public FlexibleIntPropertyResponseDto(int value, string propertyName = "IntProperty")
    {
        Value = value;
        PropertyName = propertyName;
    }
}

/// <summary>
/// Кастомный конвертер класса <see cref="FlexibleIntPropertyResponseDto"/>
/// </summary>
public class FlexibleIntPropertyConverter : JsonConverter<FlexibleIntPropertyResponseDto>
{
    public override FlexibleIntPropertyResponseDto Read(ref Utf8JsonReader reader, Type typeToConvert, 
        JsonSerializerOptions options)
    {
        throw new NotImplementedException("Deserialization is not supported for dynamic properties");
    }

    public override void Write(Utf8JsonWriter writer, FlexibleIntPropertyResponseDto value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        writer.WritePropertyName(value.PropertyName);
        writer.WriteNumberValue(value.Value);
        
        if (!string.IsNullOrEmpty(value.ReturnUrl))
        {
            writer.WritePropertyName("ReturnUrl");
            writer.WriteStringValue(value.ReturnUrl);
        }
        
        writer.WriteEndObject();
    }
}