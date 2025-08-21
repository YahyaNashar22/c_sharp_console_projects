class Program
{
  delegate void MyDelegate1();
  delegate int MyDelegate2(int x, int y);
  delegate string MyDelegate3(int x, int y);
  delegate int AnonymousDelegate(int x, int y);
  delegate string lambdaDelegate(string name);

  static void Method1()
  {
    Console.WriteLine("I am method 1!");
  }

  static int Method2(int x, int y)
  {
    Console.WriteLine("I am method 2!");
    return x + y;
  }

  static string Method3(int x, int y)
  {
    Console.WriteLine("I am method 3!");
    return $"Adding {x} and {y} will return {x + y}";
  }
  static void Method4()
  {
    Console.WriteLine("I am method 4!");
  }


  static void Main(string[] args)
  {
    #region delegates

    MyDelegate1? del1 = Method1;
    MyDelegate2 del2 = Method2;
    MyDelegate3 del3 = Method3;

    del1();
    Console.WriteLine("subscribed method 4 to del1");
    del1 += Method4;
    del1();
    Console.WriteLine("un-subscribed method 4 from del1");
    del1 -= Method1;
    del1?.Invoke();
    Console.WriteLine("-+-+-+-+-+-+-+-+-+");
    int resultOfDel2 = del2(3, 4);
    Console.WriteLine(resultOfDel2);
    Console.WriteLine("-+-+-+-+-+-+-+-+-+");
    Console.WriteLine(del3(4, 5));
    Console.WriteLine("-+-+-+-+-+-+-+-+-+");
    #endregion

    #region anonymous functions

    AnonymousDelegate multiplication = delegate (int x, int y)
    {
      Console.WriteLine("anonymous function called");
      int total = x * y;
      return total;
    };

    Console.WriteLine(multiplication(3, 5));

    Console.WriteLine("-+-+-+-+-+-+-+-+-+");


    #endregion

    #region lambdas

    Func<int, int> lambdaMethod = x => x * 12;
    Console.WriteLine(lambdaMethod(2));

    Console.WriteLine("-+-+-+-+-+-+-+-+-+");

    lambdaDelegate lambdaMethod2 = name => $"your name is {name}";

    Console.WriteLine(lambdaMethod2("yahya"));

    Console.WriteLine("-+-+-+-+-+-+-+-+-+");


    #endregion
  }
}