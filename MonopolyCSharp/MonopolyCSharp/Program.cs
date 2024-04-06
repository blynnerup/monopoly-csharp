namespace MonopolyCSharp;

public static class Program
{
    public static bool GameExited { get; set; } = false;
    private static void Main(string[] args)
    {
        var gl = new GameLogic();
        gl.RunMenu();
    }
}