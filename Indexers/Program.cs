class Program
{
  static void Main(string[] args)
  {
    Player archer = new Player(2, 10, PlayerType.Archer, Inventory.Melee, Inventory.Range);
    archer.Display();
    archer[1] = Inventory.Lighting.ToString();
    archer.Display();
    Console.WriteLine(archer[0]);
    Console.WriteLine(archer[3]);
  }
}