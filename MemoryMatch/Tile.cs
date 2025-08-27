class Tile
{
  public string Emoji { get; }
  public TileState State = TileState.Hidden;
  public Tile(string emoji)
  {
    Emoji = emoji;
  }

}