using System.Text.Json;

namespace MonopolyCSharp;

public class GameBoard
{
    public List<GameBoardField>? Fields { get; set; } = [];
    public List<ChanceCard>? ChanceCards { get; set; }
    public JsonSerializerOptions _options { get; set; }

    public GameBoard()
    {
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public void InitializeBoard()
    {
        // var jsonString = File.ReadAllText("StaticGameData/testGameField.json");
        var jsonString = File.ReadAllText("StaticGameData/gameFields.json");
        // var field = JsonSerializer.Deserialize<GameBoardField>(jsonString, options);
        Fields = JsonSerializer.Deserialize<List<GameBoardField>>(jsonString, _options)!;
    }

    public void InitializeChanceCards()
    {
        var jsonString = File.ReadAllText("StaticGameData/testChanceCard.json");
        ChanceCards = JsonSerializer.Deserialize<List<ChanceCard>>(jsonString, _options);
    }
}