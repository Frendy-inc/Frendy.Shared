using System.Security.Cryptography;

namespace Frendy.Shared.Helpers;

public static class SharedHelper
{
    /// <summary>
    /// Генерация случайного цифрового код
    /// </summary>
    /// <param name="digitCount">Количество цифр в коде (должно быть от 1 до 9)</param>
    /// <returns>Строка, содержащая случайный цифровой код</returns>
    public static string GenerateRandomCode(int digitCount)
    {
        if (digitCount <= 0 || digitCount > 9)
            throw new ArgumentOutOfRangeException(nameof(digitCount), "The code length must be between 1 and 9 digits");

        var minValue = (int)Math.Pow(10, digitCount - 1);
        var maxValue = (int)Math.Pow(10, digitCount) - 1;

        var code = RandomNumberGenerator.GetInt32(minValue, maxValue + 1);
        return code.ToString($"D{digitCount}");
    }

    /// <summary>
    /// Генерация уникального логина
    /// </summary>
    /// <returns>Строка, содержащая уникальный логин</returns>
    public static string GenerateUserName()
    {
        var guidDigits = string.Concat(Guid.NewGuid()
            .ToByteArray()
            .Select(b => b.ToString("D3")));
    
        var numbers = new string(guidDigits
            .Where(char.IsDigit)
            .Take(10)
            .ToArray());
    
        numbers = numbers.PadLeft(10, '0');
    
        return $"user_{numbers}";
    }
}