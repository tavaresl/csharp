using System;

namespace Cases
{
  public class Fibonacci
  {
    public static void Run() {
      Console.WriteLine("\nHow many steps would you like to calc?");

      var MaxSteps = int.Parse(Console.ReadLine());
      var step = 0;

      Console.WriteLine("\nCalculating...\n");

      while(step < MaxSteps)
      {
        Console.WriteLine(calc(step));
        step++;
      }
    }

    private static int calc(int value)
    {
      return value < 2
        ? 1
        : calc(value - 1) + calc(value - 2);
    }
  }
}
