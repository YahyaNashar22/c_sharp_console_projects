enum PlayerType
{
  Archer,
  Magician,
  Grant,
  Knight,
  Emperor,
  Hybrid
}

enum Inventory
{
  Melee,
  Range,
  SelfHeal,
  ReviveDead,
  Teleport,
  Berserk,
  Lighting,
  Poison,
  SmokeCloud
}

class Player
{
  private int skillSet;
  private int xp;
  private PlayerType playerType;
  private string[] inventoryTable;

  public Player(int _skillSet, int _xp, PlayerType _playerType, params Inventory[] inventories)
  {
    skillSet = _skillSet;
    xp = _xp;
    playerType = _playerType;
    inventoryTable = new string[skillSet];
    FillInventory(inventories);

  }

  private void FillInventory(Inventory[] inventories)
  {
    for (int i = 0; i < inventoryTable.Length; i++)
    {
      inventoryTable[i] = inventories[i].ToString();
    }
  }

  public string this[int index]
  {
    get
    {
      if (index >= 0 && index < inventoryTable.Length)
      {
        return inventoryTable[index];
      }
      else
      {
        return "Inventory doesn't exist for " + index;
      }
    }
    set
    {
      if (index > 0 && index < inventoryTable.Length)
      {
        inventoryTable[index] = value;
      }
      else
      {
        Console.WriteLine("\nInventory cannot be set at " + value);
      }
    }
  }

  public void Display()
  {
    Console.WriteLine("\n" + playerType.ToString() + " has " + skillSet + " skills with an xp of " + xp);
    Console.WriteLine("\nThe " + playerType.ToString() + " 's skills are: ");
    for (int i = 0; i < inventoryTable.Length; i++)
    {
      Console.WriteLine(inventoryTable[i]);
    }
  }
}