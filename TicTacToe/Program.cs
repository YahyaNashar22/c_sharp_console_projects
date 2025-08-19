using System;
class Program
{
  static string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
  static bool player = true;
  static Random rand = new Random();

  static int numTurns = 0;

  static void printBoard()
  {
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        string cell = board[i * 3 + j];
        if (cell == "X")
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write(cell);
          Console.ResetColor();
        }
        else if (cell == "O")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write(cell);
          Console.ResetColor();
        }
        else
        {
          Console.Write(cell);
        }
        Console.Write("|");
      }
      Console.WriteLine();
      Console.WriteLine("------");
    }
  }

  static bool CheckVictory()
  {
    bool row1 = board[0] == board[1] && board[1] == board[2];
    bool row2 = board[3] == board[4] && board[4] == board[5];
    bool row3 = board[6] == board[7] && board[7] == board[8];

    bool col1 = board[0] == board[3] && board[3] == board[6];
    bool col2 = board[1] == board[4] && board[4] == board[7];
    bool col3 = board[2] == board[5] && board[5] == board[8];

    bool diag1 = board[0] == board[4] && board[4] == board[8];
    bool diag2 = board[2] == board[4] && board[4] == board[6];

    return row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2;

  }

  static void TakeInput(int input)
  {


    if (input < 1 || input > 9)
    {
      Console.WriteLine("Invalid Slot");
      return;
    }
    if (!int.TryParse(board[input - 1], out _))
    {
      Console.WriteLine("Slot already taken");
      return;
    }
    board[input - 1] = player ? "X" : "O";

    Console.Clear();
    player = !player;
    numTurns++;

    printBoard();
  }
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome To The Console Tic Tac Toe!");
    Console.WriteLine("####################################");
    Console.WriteLine();

    printBoard();

    while (!CheckVictory() && numTurns != 9)
    {
      Console.WriteLine();
      int input = player ? int.Parse(Console.ReadLine()!) : rand.Next(1, 10);
      TakeInput(input);
    }

    if (CheckVictory())
    {
      Console.WriteLine(!player ? "You Won !" : "You Lost!");
    }
    else
    {
      Console.WriteLine("Draw!");
    }
  }
}