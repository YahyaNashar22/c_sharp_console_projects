using System;
class Program
{
  static string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

  static void printBoard()
  {
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write(board[i * 3 + j] + "|");
      }
      Console.WriteLine();
      Console.WriteLine("------");
    }
  }
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome To The Console Tic Tac Toe!");
    Console.WriteLine("####################################");
    Console.WriteLine();

    printBoard();

  }
}