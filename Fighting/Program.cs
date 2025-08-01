using System;

class Program
{

    #region game variables
    int playerHp = 100;
    int enemyHp = 150;

    int playerDmg = 25;
    int enemyDmg = 30;

    int enemyChoice;
    string playerChoice;

    int heal = 20;

    Random random = new Random();

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
        Console.WriteLine($"You attacked with damage: {playerDmg}");
        Console.WriteLine();
    }

    private void PlayerHeal()
    {
        playerHp += heal;
        Console.WriteLine();
        Console.WriteLine($"You healed for: {heal}");
        Console.WriteLine();
    }

    private void EnemyAttack()
    {
        playerHp -= enemyDmg;
        Console.WriteLine();
        Console.WriteLine($"Enemy attacked with damage: {enemyDmg}");
        Console.WriteLine();
    }

    private void EnemyHeal()
    {
        enemyHp += heal;
        Console.WriteLine();
        Console.WriteLine($"Enemy healed for: {heal}");
        Console.WriteLine();
    }

    private void CheckGameOver()
    {

        if (enemyHp <= 0) { Console.WriteLine("You Win!"); DisplayHud(); gameOver = true; }
        if (playerHp <= 0) { Console.WriteLine("You Lose!"); DisplayHud(); gameOver = true; }
    }

    private void EnemyChoice()
    {

        enemyChoice = random.Next(0, 2);
        if (enemyChoice == 0)
        {
            EnemyAttack();
            CheckGameOver();
        }
        else
        {
            EnemyHeal();
            CheckGameOver();
        }
    }

    private void PlayerChoice()
    {
        Console.WriteLine();
        Console.WriteLine("What do you want to do ?");
        playerChoice = Console.ReadLine()!;
        DisplayHud();
        if (playerChoice == "a")
        {
            PlayerAttack();
            CheckGameOver();
            return;
        }
        if (playerChoice == "h")
        {
            PlayerHeal();
            CheckGameOver();
            return;
        }
        else
        {
            Console.WriteLine("Please enter a valid choice!");
            PlayerChoice();
            return;
        }
    }

    private void DisplayHud()
    {
        string playerBox = $@"
+----------------------+
|   Player Health      |
|      {playerHp,5} HP        |
+----------------------+";

        string enemyBox = $@"
+----------------------+
|   Enemy Health       |
|      {enemyHp,5} HP        |
+----------------------+";
        Console.Clear();
        Console.WriteLine(playerBox);
        Console.WriteLine();
        Console.WriteLine(enemyBox);
    }


    private void StartGame()
    {
        PlayerChoice();
        EnemyChoice();
    }

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        Program program = new Program();
        while (!gameOver)
        {
            program.StartGame();
        }
    }
}