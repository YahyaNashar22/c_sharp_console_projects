enum PlayerType
{
  Archer,
  Magician,
  Grunt,
  Knight,
  Emperor,
  Hybrid
}

class Player
{
  private int skillSets;
  private int xp;
  private PlayerType playerType;
  public Player(int _skillsSet, int _xp, PlayerType _playerType)
  {
    skillSets = _skillsSet;
    xp = _xp;
    playerType = _playerType;
  }

  public void Display()
  {
    Console.WriteLine("\n" + playerType.ToString() + " has " + skillSets + " skills with an XP of " + xp);
  }

  public static Player operator +(Player player1, Player player2)
  {
    return new Player(player1.skillSets + player2.skillSets, player1.xp + player2.xp, PlayerType.Hybrid);
  }
  public static Player operator +(Player player, int xp)
  {
    player.xp += xp;
    Console.WriteLine("\n" + "Player now has an XP of " + player.xp);
    return player;
  }
}