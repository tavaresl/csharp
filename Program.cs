using System;
using System.Linq;
using Cases;

namespace myAoo
{
  class Program
  {
    static void Main(string[] args)
    {
      // var chapter = args.Any() ? args[0] : null;
      // Run(chapter);

      if (args.Any())
        Run(args[0]);
      else
        RunFromPrompt();
    }

    private static void RunFromPrompt()
    {
      Console.WriteLine("Which chapter would you like to run?");
      Console.WriteLine(@"
        0 - Fibonacci
        1 - Arrays and Lists
      ");

      string command;
      int val;

      do
      {
        command = Console.ReadLine();
      }
      while(!int.TryParse(command, out val));

      Run(command);
    }

    private static void Run(string cmd)
    {
      switch (cmd.ToLower())
      {
        case "fibonacci":
        case "-fib":
        case "0":
          new Fibonacci().Run();
          return;

        case "arrayandlists":
        case "-aal":
        case "1":
          new ArraysAndLists().Run();
          return;

        default:
          Console.WriteLine("Invalid argument");
          RunFromPrompt();
          return;
      }
    }
  }
}
