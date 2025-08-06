static class StaticMessages
{
  static public void Farewell()
  {
    Console.WriteLine("Come back soon and be more productive!");
  }

  static public void ShowControls()
  {
    Console.WriteLine("\nChoose what would you like to do:");
    Console.WriteLine("[1] - Add Task\n[2] - Remove Task\n[3] - List All Tasks\n[4] - Save Tasks\n[5] - Load Tasks\n[exit] - exit the program");
  }

  static public void WelcomeMessage()
  {
    Console.WriteLine("Welcome to your new favorite todo list application!");
  }
}