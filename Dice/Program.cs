using System;
using System.Threading;

class Program
{
  static void Main(string[] args)
  {

    int playerDice, enemyDice;
    int playerScore = 0;
    int enemyScore = 0;
    Random random = new Random();

    Console.WriteLine("Welcome to our Dice Game!");
    Console.WriteLine("#########################");

    for (int i = 0; i < 4; i++)
    {
      Console.WriteLine("Press Any Button To Roll The Dice");
      Console.ReadKey();

      playerDice = random.Next(1, 7);
      Console.WriteLine($"You Rolled: {playerDice}");

      Thread.Sleep(1000);

      enemyDice = random.Next(1, 7);
      Console.WriteLine($"Enemy Rolled: {enemyDice}");

      if (playerDice < enemyDice)
      {
        enemyScore++;
        Console.WriteLine("Enemy scored higher!");
      }
      else if (playerDice > enemyDice)
      {
        playerScore++;
        Console.WriteLine("You scored higher!");
      }
      else
      {
        playerScore++;
        enemyScore++;
        Console.WriteLine("You both Scored the same!");
      }

      Console.WriteLine();

    }
    if (playerScore < enemyScore)
    {
      Console.WriteLine("Enemy Won!");
    }
    else if (playerScore > enemyScore)
    {
      Console.Write("You Won!");
    }
    else
    {
      Console.WriteLine("Draw!");
    }

    Console.WriteLine();

    Console.WriteLine("############################");
    Console.WriteLine("# Thanks for playing dice! #");
    Console.WriteLine("# Come again soon! #");
    Console.WriteLine("############################");

  }
}