using System.Diagnostics;

class Controls
{
  private readonly ITodoList _todoList;
  public Controls(ITodoList todoList)
  {
    _todoList = todoList;
  }

  public void ShowMenu()
  {
    StaticMessages.ShowControls();
    string input = Console.ReadLine() ?? "";
    Console.WriteLine();
    HandleAction(input);
  }

  public void HandleAction(string userInput)
  {
    Console.Clear();

    switch (userInput)
    {
      case "1":
        Console.WriteLine("Enter the task:");
        string task = Console.ReadLine() ?? "";
        _todoList.AddTask(task);
        break;
      case "2":
        Console.WriteLine("Enter the number of task you want to remove:");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
          _todoList.RemoveTask(index);
        }
        else
        {
          Console.WriteLine("Invalid Input");
        }
        break;
      case "3":
        _todoList.ListAll();
        break;
      case "4":
        _todoList.Save();
        break;
      case "5":
        _todoList.Load();
        break;
      case "exit":
        StaticMessages.Farewell();
        Environment.Exit(0);
        break;
      default:
        Console.WriteLine("Invalid Option!");
        break;
    }
    ShowMenu();

  }
}