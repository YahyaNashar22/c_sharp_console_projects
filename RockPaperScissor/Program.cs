using System;

class Program
{
  static void Main(string[] args)
  {
    Game.IntroMessage();
    Game game = new Game();

    while (game.GetPlayerScore() < 3 && game.GetEnemyScore() < 3)
    {
      game.CapturePlayerChoice();
      game.CaptureEnemyChoice();
      game.Score(game.GetPlayerOption(), game.GetEnemyOption());
      game.PrintScore();
      Console.WriteLine();
    }
  }
}