using System;
using System.Text;
using System.Linq;

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
            var header = new StringBuilder("Check if numbers are consecutive")
                .AppendLine()
                .Append("Enter some numbers, separated by dash (-)");

            Console.WriteLine(header);

            var typedNumbers = Console.ReadLine();
            var numbers = typedNumbers.Split("-").Select(num => int.Parse(num)).ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine("Number: " + num);   
            }
        }
    }
}
