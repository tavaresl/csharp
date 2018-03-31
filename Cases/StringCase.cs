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
                .Append("1 - Check if numbers are consecutive\n")
                .Append("2 - Check if there are duplicate numbers\n")
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

                case "2":
                    IsThereDuplicates();
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

            for (var i = 0; i < numbers.Count() - 1; i++)
            {
                if (!(Math.Abs(numbers[0] - numbers[1]) == 1))
                {
                    Console.WriteLine("Not consecutive");
                    return;
                }
            }

            Console.WriteLine("Consecutive");
        }

        public void IsThereDuplicates()
        {
            Console.Clear();

            var header = new StringBuilder("Check if there are duplicate numbers")
                .AppendLine()
                .Append("Enter some numbers, separated by dash");
            
            Console.WriteLine(header);

            var typped = Console.ReadLine();

            if (String.IsNullOrEmpty(typped))
                return;

            var numbers = typped.Split('-');
            string[] uniques = new string[numbers.Length];

            for (var i = 0; i < numbers.Length; i++)
            {
                if (uniques.Contains(numbers[0]))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }

                uniques[i] = numbers[i];
            }
        }
    }
}
