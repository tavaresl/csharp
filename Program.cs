using System;
using System.Linq;
using Cases;

namespace myAoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var argument = args.Any() ? args[0] : ReadArgumentFromPrompt();
            Run(argument);
        }

        private static string ReadArgumentFromPrompt()
        {
            Console.WriteLine("Which case would you like to run?");
            return Console.ReadLine();
        }

        private static void Run(string cmd)
        {
            switch (cmd.ToLower())
            {
                case "fibonacci":
                case "-fib":
                    new Fibonacci().Run();
                    break;

                default:
                    Console.WriteLine("Invalid argument");
                    break;
            }
        }
    }
}
