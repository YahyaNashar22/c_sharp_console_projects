using System;

class Program
{
  static void Main(string[] args)
  {
    Console.ResetColor();
    ITodoList todoList = new TodoList();
    Controls controls = new Controls(todoList);
    StaticMessages.WelcomeMessage();

    while (true)
    {
      controls.ShowMenu();
    }
  }
}