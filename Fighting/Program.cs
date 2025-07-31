using System;

class Program
{

  #region game variables
  int playerHp = 100;
  int enemyHp = 150;

  int playerDmg = 25;
  int enemyDmg = 30;

  int heal = 20;

  static bool gameOver = false;

  #endregion

  private static void DisplayWelcomeMessage()
  {
    Console.WriteLine();
    Console.WriteLine("## Welcome to fighting game 1.0! ##");
    Console.WriteLine("Finish off your opponent first to win!");
    Console.WriteLine("[a] - attack");
    Console.WriteLine("[h] - heal");
    Console.WriteLine("Fight!");
    Console.WriteLine();
  }

  private void PlayerAttack()
  {
    enemyHp -= playerDmg;
    Console.WriteLine();
    Console.WriteLine($"You attacked with damage: {playerDmg}, enemy is now at: ${enemyHp} HP");
    Console.WriteLine();
  }

  private void PlayerHeal()
  {
    playerHp += heal;
    Console.WriteLine();
    Console.WriteLine($"You healed for: {heal}, you're now at: ${playerHp} HP");
    Console.WriteLine();
  }

  private void EnemyAttack()
  {
    playerHp -= enemyDmg;
    Console.WriteLine();
    Console.WriteLine($"Enemy attacked with damage: {enemyDmg}, you're now at: ${playerHp} HP");
    Console.WriteLine();
  }
  private void EnemyHeal()
  {
    enemyHp += heal;
    Console.WriteLine();
    Console.WriteLine($"Enemy healed for: {heal}, Enemy is now at: ${enemyHp} HP");
    Console.WriteLine();
  }

  static void Main(string[] args)
  {



    DisplayWelcomeMessage();
    while (!gameOver)
    {
    }


  }
}