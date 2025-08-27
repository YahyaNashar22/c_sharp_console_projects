class Board
{
  private static readonly string[] emojiSet = new string[]
{
    "🍎","🍌","🍇","🍉","🍒","🍓",
    "🍍","🥝","🥑","🍋","🍊","🍐"
};
  private readonly int rows;
  private readonly int columns;
  private readonly Tile[] tiles;
  private readonly Random rand = new Random();
  public int Moves { get; private set; }
  public int MatchesFound { get; private set; }

  public Board(int rows, int columns)
  {
    if (rows * columns % 2 != 0)
    {
      throw new ArgumentException("Number of cells must be even!");
    }
    this.rows = rows;
    this.columns = columns;
    tiles = new Tile[rows * columns];
    InitializeTiles();
  }

  // create the pairs twice, then shuffle and assign the tiles array
  public void InitializeTiles()
  {
    int pairs = tiles.Length / 2; // create pairs from half the array
    List<string> values = new List<string>(tiles.Length);
    for (int v = 1; v <= pairs; v++)
    {
      // add it twice cause each value should have its match
      values.Add(emojiSet[v]); values.Add(emojiSet[v]);
    }

    // shuffle the values using Fisher-Yates ( smtg new i learned )
    for (int i = values.Count - 1; i > 0; i--)
    {
      int j = rand.Next(i + 1); // shuffle randomly based on the remaining indexes
      (values[i], values[j]) = (values[j], values[i]);
    }

    // fill in the tiles with their values
    for (int i = 0; i < tiles.Length; i++)
    {
      tiles[i] = new Tile(values[i]);
    }

    // initial state of Moves and Matches Found
    Moves = 0;
    MatchesFound = 0;
  }

  // Draw the board.
  // Hidden tiles show their position number
  // Revealed or Matched tiles show their value
  public void DrawBoard(bool revealAll = false)
  {
    Console.WriteLine();
    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < columns; c++)
      {
        int index = r * columns + c;
        var t = tiles[index];
        string cell = (revealAll || t.State is TileState.Revealed or TileState.Matched) ? t.Emoji.ToString() : (index + 1).ToString();
        Console.Write($" {cell,4} "); // the ",4" is used for padding
      }
      Console.WriteLine();
      Console.WriteLine();
    }
  }

  // Read / Validate a tile selection from the player
  private int GetSelection(string prompt)
  {
    while (true)
    {
      Console.Write(prompt);
      string? input = Console.ReadLine();
      if (!int.TryParse(input, out int pick))
      {
        Console.WriteLine("Please enter a number.");
        continue;
      }
      int index = pick - 1;
      if (index < 0 || index > tiles.Length)
      {
        Console.WriteLine($"Pick a number between 1 and {tiles.Length}");
        continue;
      }
      if (tiles[index].State == TileState.Matched)
      {
        Console.WriteLine("That tile is already matched. Choose another.");
        continue;
      }
      if (tiles[index].State == TileState.Revealed)
      {
        Console.WriteLine("That tile is already flipped this turn. Choose another");
        continue;
      }
      return index;
    }
  }

  public void Play()
  {
    while (MatchesFound < tiles.Length / 2)
    {
      Console.Clear();
      Console.WriteLine($"Memory Match -- Moves: {Moves}, Matches: {MatchesFound}/{tiles.Length / 2}");
      DrawBoard();

      int first = GetSelection("Pick the FIRST tile (number): ");
      tiles[first].State = TileState.Revealed;

      Console.Clear();
      Console.WriteLine($"Memory Match -- Moves: {Moves}, Matches: {MatchesFound}/{tiles.Length / 2}");
      DrawBoard();

      int second;
      while (true)
      {
        second = GetSelection("Pick the SECOND tile (number): ");
        if (second == first)
        {
          Console.WriteLine("You can't pick the same tile twice.");
        }
        else break;
      }
      tiles[second].State = TileState.Revealed;

      Moves++;

      Console.Clear();
      Console.WriteLine($"Memory Match -- Moves: {Moves}, Matches: {MatchesFound}/{tiles.Length / 2}");
      DrawBoard();

      if (tiles[first].Emoji == tiles[second].Emoji)
      {
        tiles[first].State = TileState.Matched;
        tiles[second].State = TileState.Matched;
        MatchesFound++;
        Console.WriteLine("Nice! It's a match.");
        Thread.Sleep(900);
      }
      else
      {
        Console.WriteLine("Not a match.");
        Thread.Sleep(1300);
        tiles[first].State = TileState.Hidden;
        tiles[second].State = TileState.Hidden;
      }
    }

    Console.Clear();
    Console.WriteLine("🎉 You won!");
    Console.WriteLine($"Total moves: {Moves}");
    DrawBoard(revealAll: true);
  }
}