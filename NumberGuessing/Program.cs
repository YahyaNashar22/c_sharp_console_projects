using System;

class Program
{
  static void Main(string[] args)
  {
    Random random = new Random();

    int userInput;
    int correctAnswer;
    string userRepeat;
    bool repeat = true;


    Console.WriteLine("Welcome To The Number Guessing Game!");


    while (repeat)
    {
      Console.WriteLine("Choose a number between 1 and 10");
      Console.WriteLine("If you guess the right number you win!");
      Console.WriteLine();

      userInput = Convert.ToInt32(Console.ReadLine());
      correctAnswer = random.Next(1, 11);

      if (userInput == correctAnswer)
      {
        Console.WriteLine($"Congrats! You guessed the right number: {userInput}!");
      }
      else
      {
        Console.WriteLine($":( You lost! the correct number is: {correctAnswer}");
      }

      Console.WriteLine("Would you like to try again?");
      Console.WriteLine("[y] yes  |  [n] no");
      userRepeat = Console.ReadLine()!;
      if (userRepeat == "y")
      {
        repeat = true;
      }
      else
      {
        repeat = false;
        Console.WriteLine("Hope you enjoyed! Come back soon!");
      }

    }
  }
}