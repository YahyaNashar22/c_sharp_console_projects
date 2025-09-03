public class Game
{
    // event with no extra data
    public event EventHandler? GameOver;
    public event EventHandler<string>? GameStart;
    // event with extra data
    public event EventHandler<PlayerEventArgs>? PlayerDied;

    public void EndGame()
    {
        Console.WriteLine("Game is ending . . . ");
        // Emit ( raise ) event 
        GameOver?.Invoke(this, EventArgs.Empty);
    }

    public void StartGame(string level)
    {
        GameStart?.Invoke(this, level);
    }

    public void KillPlayer(string playerName)
    {
        Console.WriteLine($"{playerName} died . . . ");
        // Emit ( raise ) event
        PlayerDied?.Invoke(this, new PlayerEventArgs(playerName));
    }
}