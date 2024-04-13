using System.Text.Json;

namespace MonopolyCSharp;

public class GameBoard
{
    public List<GameBoardField>? Fields { get; set; }
    public List<ChanceCard>? ChanceCards { get; set; }

    public GameBoard()
    {
        Fields = new List<GameBoardField>();

    }
    public void InitializeBoard()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var jsonString = File.ReadAllText("StaticGameData/gameFields.json");
        // var field = JsonSerializer.Deserialize<GameBoardField>(jsonString, options);
        Fields = JsonSerializer.Deserialize<List<GameBoardField>>(jsonString)!;
    }

    private void InitializeChanceCards()
    {
        
    }
}