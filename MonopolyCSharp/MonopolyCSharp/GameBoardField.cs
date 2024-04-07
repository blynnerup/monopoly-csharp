namespace MonopolyCSharp;

public class GameBoardField
{
    public string Text { get; set; } = null!;
    public int FieldNumber { get; set; }
    public string Type { get; set; } = null!;
    public int? Price { get; set; }
    public int? Group { get; set; }
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