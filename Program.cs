using System;
using Cases;
using System.Linq;

namespace myAoo
{
  class Program
  {
    static void Main(string[] args)
    {
      var argument = args.Any() ? args[0] : readArgumentFromPrompt();
      run(argument);
    }

    private static string readArgumentFromPrompt()
    {
      Console.WriteLine("Which case would you like to run?");
      return Console.ReadLine();
    }

    private static void run(string cmd)
    {
      switch (cmd.ToLower())
      {
        case "fibonacci":
        case "-fib":
          Fibonacci.Run();
          break;

        default:
          Console.WriteLine("Invalid argument");
          break;
      }
    }
  }
}
