using System.Diagnostics.Metrics;

namespace MonopolyCSharp;

public class GameLogic
{
    private bool GameRunning { get; set; } = false;

    private bool _validKeyEntered = false;
    public void RunMenu()
    {
        // Display the number of command line arguments.
        Console.WriteLine("Welcome to a fun game of Monopoly");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Pick a number:");
        Console.WriteLine("1. Start new game");
        Console.WriteLine("2. Exit game");
        
        while (!_validKeyEntered)
        {
            var key = Console.ReadLine();
            Console.WriteLine(key);
            switch (key)
            {
                case "1":
                    GameRunning = true;
                    NewGame();
                    _validKeyEntered = true;
                    break;
                case "2":
                    Program.GameExited = true;
                    GameRunning = false;
                    _validKeyEntered = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid key, try again");
                    break;
            }
        }
        if (_validKeyEntered && Program.GameExited)
            Console.WriteLine("Thanks for playing, bye!");
    }

    /// <summary>
    /// Initializes the game.
    /// </summary>
    private  void NewGame()
    {
        Console.WriteLine("Game initializing");
        while (GameRunning && !Program.GameExited)
        {
            
        }
    }
}