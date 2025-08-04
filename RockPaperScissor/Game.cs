using System;

class Game
{
  Random random = new Random();
  string playerOption;
  int enemyOption;
  int playerScore = 0;
  int enemyScore = 0;
  public static void IntroMessage()
  {
    Console.WriteLine("Welcome to the Rock, Paper, Scissor game!\nWe're excited to see you play!");
    Console.WriteLine("[r] - rock\n[p] - paper\n[s] - scissor");
  }

  public void CapturePlayerChoice()
  {
    Console.WriteLine("What is your next shape?");
    playerOption = Console.ReadLine()!;
  }

  public void CaptureEnemyChoice()
  {
    enemyOption = random.Next(0, 3);

    switch (enemyOption)
    {
      case 0:
        Console.WriteLine("Enemy chose: Rock");
        break;
      case 1:
        Console.WriteLine("Enemy chose: Paper");
        break;
      case 2:
        Console.WriteLine("Enemy chose: Scissor");
        break;
    }
  }

    public void Score(string playerChoice, int enemyChoice)
  {
    switch (playerChoice)
    {
      case "r":
        if (enemyChoice == 0)
        {
          Console.WriteLine("Draw!");
        }
        if (enemyChoice == 1)
        {
          Console.WriteLine("Draw!");

        }
        if (enemyChoice == 2)
        {
          Console.WriteLine("Draw!");

        }
        break;
      case "p":
        if (enemyChoice == 0)
        {
          Console.WriteLine("Draw!");

        }
        if (enemyChoice == 1)
        {
          Console.WriteLine("Draw!");

        }
        if (enemyChoice == 2)
        {
          Console.WriteLine("Draw!");

        }
        break;
      case "s":
        if (enemyChoice == 0)
        {
          Console.WriteLine("Draw!");

        }
        if (enemyChoice == 1)
        {
          Console.WriteLine("Draw!");

        }
        if (enemyChoice == 2)
        {
          Console.WriteLine("Draw!");

        }
        break;
    }
  }
}