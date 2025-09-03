public class PlayerEventArgs
{
    public string PlayerName { get; }
    public PlayerEventArgs(string playerName)
    {
        PlayerName = playerName ?? "unknown player";
    }
}