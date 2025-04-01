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
        Fields = JsonSerializer.Deserialize<List<GameBoardField>>(jsonString, options)!;
        
    }

    public void InitializeChanceCards()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var jsonString = File.ReadAllText("StaticGameData/gameFields.json");
        // Create array for the chance cards
        // Shuffle the array to randomize card draw
    }
}