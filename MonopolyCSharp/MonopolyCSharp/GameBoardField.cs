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
    None = 0, // No effect on card
    Chance = 1, // Draw a card
    SubBalance = 2, // Subtract from balance
    Balance = 3, // Add to balance
    Jailed = 4, // Jailed for x turns
    Visiting = 5, // Jail
    Choice = 6, // Cards or fields with a choice
    Parking = 7, // Redundant?
    Move = 8, // Move to a field (game field Id)
    Tax = 9, // Chance card tax (could also be used for game field choice?
    Collect = 10 // From other players
}