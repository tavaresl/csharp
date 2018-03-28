using System;
using System.Text;

namespace Cases
{
    public class StringCase
    {
        public void Run()
        {
            Console.Clear();

            var header = new StringBuilder("Working with Text")
                .AppendLine()
                .AppendLine()
                .Append("Choose an exercise")
                .AppendLine()
                .AppendLine()
                .Append("1 - Check if numbers are consecutive")
                .AppendLine();


            Console.WriteLine(header);

            string exercise;
            int parsed;

            do
                exercise = Console.ReadLine();
            while (!Int32.TryParse(exercise, out parsed));
                
            switch (exercise)
            {
                case "1":
                    IsConsecutive();
                    break;

                default:
                    Console.Write("Exercise not found");
                    break;
            }
        }

        public void IsConsecutive()
        {
            Console.Clear();
            Console.WriteLine("Enter some numbers, separated by dash (-)");

            var typedNumbers = Console.ReadLine();

        }
    }
}
