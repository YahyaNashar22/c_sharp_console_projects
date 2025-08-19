class Program
{
  static void Main(string[] args)
  {
    Player archer = new Player(2, 10, PlayerType.Archer);
    Player magician = new Player(4, 20, PlayerType.Magician);

    archer.Display();

    Player hybridWarrior = archer + magician;

    hybridWarrior.Display();

    _ = hybridWarrior + 23;
  }
}
