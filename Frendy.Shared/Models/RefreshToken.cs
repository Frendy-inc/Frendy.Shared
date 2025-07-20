namespace Frendy.Shared.Models;

public class RefreshToken
{
    public required string Token { get; set; }
    public required long Expires { get; set; }
}