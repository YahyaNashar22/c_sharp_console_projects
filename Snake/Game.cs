class Game
{
  static Coord gridDimensions = new Coord(50, 20);
  Coord snakePosition = new Coord(10, 1);
  static Random rand = new Random();
  Coord applePosition = new Coord(rand.Next(1, gridDimensions.X - 1), rand.Next(1, gridDimensions.Y - 1));

  public void DrawGrid()
  {
    for (int y = 0; y < gridDimensions.Y; y++)
    {
      for (int x = 0; x < gridDimensions.X; x++)
      {
        Coord currentCoord = new Coord(x, y);

        if (snakePosition.Equals(currentCoord))
        {
          Console.Write("■");
        }
        else if (applePosition.Equals(currentCoord))
        {
          Console.Write("a");
        }
        else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
        {
          Console.Write("#");
        }
        else Console.Write(" ");
      }
      Console.WriteLine();
    }
  }
}