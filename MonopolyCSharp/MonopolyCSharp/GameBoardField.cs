using System.Runtime.Serialization;

namespace MonopolyCSharp;

public class GameBoardField
{
    public string Text { get; set; } = null!;
    public string FieldNumber { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string? Price { get; set; }
    public string? Group { get; set; }
    public Special Special { get; set; } = new();
}

public class Special
{
    public Effect Effect { get; set; }
    public string? Amount { get; set; }
}

public enum Effect
{
    None,
    Chance,
    SubBalance,
    Balance,
    Jailed,
    Visiting,
    Choice,
    Parking
}