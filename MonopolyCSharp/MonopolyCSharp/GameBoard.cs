using System.Text.Json;

namespace MonopolyCSharp;

public class GameBoard
{
    public List<GameBoardField> Fields { get; set; }
    public List<ChanceCard>? ChanceCards { get; set; }

    public GameBoard()
    {
        Fields = new List<GameBoardField>();

    }
    public void InitializeBoard()
    {
        var jsonString = File.ReadAllText("StaticGameData/gameFields.json");
    }

    private void InitializeChanceCards()
    {
        
    }
}