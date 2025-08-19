using System;
using System.Threading;

class Program
{
  public void Display1()
  {
    Console.WriteLine("Start Display 1");
    // ? threads in the monitor will execute in sync and not concurrently
    Monitor.Enter(this);
    for (int i = 0; i <= 10; i++)
    {
      Console.WriteLine($"display 1: {i}");
      // ? will pause the thread for the current thread ( th1 )
      Thread.Sleep(1000);
    }
    Monitor.Exit(this);
    Console.WriteLine("End Display 1");
  }
  public void Display2()
  {
    // ? threads in the monitor will execute in sync and not concurrently
    Monitor.Enter(this);
    Console.WriteLine("Start Display 2");

    for (int i = 0; i <= 10; i++)
    {
      Console.WriteLine($"display 2: {i}");
      // ? will pause the thread for the current thread ( th2 )
      Thread.Sleep(1200);

    }
    Monitor.Exit(this);
    Console.WriteLine("End Display 2");
  }
  static void Main(string[] args)
  {
    Program p = new Program();

    // get current thread ( example functionality for a thread )
    Thread th = Thread.CurrentThread;
    th.Name = "first thread";
    Console.WriteLine($"Thread: {th.Name}");
    Console.WriteLine($"Welcome!");

    // create the delegate of the thread
    ThreadStart ts1 = new ThreadStart(p.Display1);
    ThreadStart ts2 = new ThreadStart(p.Display2);

    // create the object of the thread
    Thread th1 = new Thread(ts1);
    Thread th2 = new Thread(ts2);

    // the delegate will automatically be called when running start
    // ? will execute them concurrently
    th1.Start();
    th2.Start();

    // ? the task with higher priority will be executed first
    th1.Priority = ThreadPriority.Highest;
    th2.Priority = ThreadPriority.Lowest;


    // ? will finish the execution of the first then the second
    // p.display1();
    // p.display2();
  }
}






