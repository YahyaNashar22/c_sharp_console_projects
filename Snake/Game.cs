class Game
{
  Coord gridDimensions = new Coord(50, 20);
  Coord snakePosition = new Coord(10, 4);

  public void DrawGrid()
  {
    for (int y = 0; y < gridDimensions.Y; y++)
    {
      for (int x = 0; x < gridDimensions.X; x++)
      {
        Coord currentCoord = new Coord(x, y);

        if (snakePosition.Equals(currentCoord))
        {
          Console.WriteLine("■");
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