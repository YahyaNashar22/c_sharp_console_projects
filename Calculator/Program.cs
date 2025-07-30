using System;

class Program
{
  static void Main(string[] args)
  {
    bool repeat = true;
    string repeatAnswer;
    int num1;
    int num2;

    double result;

    string operation;


    Console.WriteLine("Hello!, Welcome to the calculator program!");

    while (repeat)
    {


      Console.WriteLine("Please Enter your first integer:");
      num1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Please Enter your second integer:");
      num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("What type of operation would you like?");
      Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division");
      operation = Console.ReadLine()!;

      switch (operation)
      {
        case "a":
          result = num1 + num2;
          Console.WriteLine($"Result: {result}");
          break;
        case "s":
          result = num1 - num2;
          Console.WriteLine($"Result: {result}");
          break;
        case "m":
          result = num1 * num2;
          Console.WriteLine($"Result: {result}");
          break;
        case "d":
          result = (double)num1 / num2;
          Console.WriteLine($"Result: {result}");
          break;
        default:
          result = 0;
          Console.WriteLine("Invalid Operation");
          break;
      }

      Console.WriteLine("Would you like to try again?");
      Console.WriteLine("[y] yes");
      Console.WriteLine("[n] no");
      repeatAnswer = Console.ReadLine();
      if (repeatAnswer == "y")
      {
        repeat = true;
        continue;
      }
      else
      {
        repeat = false;
      }
    }

    Console.WriteLine("Thank you for using the calculator!");
    Console.ReadKey();
  }
}