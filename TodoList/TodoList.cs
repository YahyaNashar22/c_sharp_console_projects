class TodoList : ITodoList
{
  readonly List<string> todos = new List<string>();

  public void AddTask(string task)
  {
    todos.Add(task);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Added Task: {task}");
    Console.ResetColor();
  }

  public void RemoveTask(int index)
  {
    if (index >= 0 && index < todos.Count)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Removed Task: {todos[index]}");
      Console.ResetColor();
      todos.RemoveAt(index);
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Invalid task number.");
      Console.ResetColor();

    }
  }

  public void ListAll()
  {
    if (todos.Count == 0)
    {
      Console.WriteLine("No tasks yet!");
      return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Your current tasks are:");
      Console.ResetColor();
      Console.WriteLine($"[{i}] {todos[i]}");
    }
  }

  public void Save()
  {
    Console.WriteLine("Tasks saved (fake save for now).");
  }

  public void Load()
  {
    Console.WriteLine("Tasks loaded (fake load for now).");
  }

}