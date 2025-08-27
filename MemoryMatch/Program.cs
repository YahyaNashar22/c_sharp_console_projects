class Program
{
  static void Main()
  {
    var board = new Board(3, 4); // change dimensions if you like (must multiply to an even number)
    board.Play();
    Console.WriteLine("Press ENTER to exit.");
    Console.ReadLine();
  }
}
