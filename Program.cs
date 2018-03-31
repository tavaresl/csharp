using System;
using System.Linq;
using System.Text;
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
			var header = new StringBuilder("Which chapter would you like to run?")
				.AppendLine()
				.AppendLine()
				.Append("0 - Fibonacci\n")
				.Append("1 - Arrays and Lists\n")
				.Append("2 - Working with Texts")
				.AppendLine();
				
            Console.WriteLine(header);

            string command;
            int val;

            do
            {
                command = Console.ReadLine();
            }
            while (!int.TryParse(command, out val));

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
                    new ArraysAndListsExercises().Run();
                    return;

                case "text":
                case "-txt":
                case "2":
                    new StringCase().Run();
                    break;

                default:
                    Console.WriteLine("Invalid argument");
                    RunFromPrompt();
                    return;
            }
        }
    }
}
