using System;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        // Subscribe with lambda
        game.GameStart += (sender, e) => Console.WriteLine($"Listener: game started at level --> {e}");
        game.GameOver += (sender, e) => Console.WriteLine("Listener: Game Over event received!");
        // Subscribe with method
        game.PlayerDied += OnPlayerDied;
        game.GameStart += OnGameStart;

        // Trigger ( emit ) events
        game.KillPlayer(playerName: "Alice");
        game.EndGame();
        game.StartGame("level2");
    }
    static void OnGameStart(object? sender, string e)
    {
        Console.WriteLine($"Listener: Game level --> {e} started!");
    }
    static void OnPlayerDied(object? sender, PlayerEventArgs e)
    {
        Console.WriteLine($"Listener: Player {e.PlayerName} died!");
    }
}