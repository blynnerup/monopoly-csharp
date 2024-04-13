namespace MonopolyCSharp;

public class GameBoardField
{
    public string Name { get; set; } = null!;
    public string FieldNumber { get; set; }
    public string Type { get; set; } = null!;
    public string? Price { get; set; }
    public string? Group { get; set; }
    public Special? Special { get; set; }

}

public class Special
{
    public List<Effect> Effects { get; set; } = null!;
}

public enum Effect
{
    Chance,
    SubBalance,
    Balance,
    Jailed,
    None,
    Visiting,
    Choice
}