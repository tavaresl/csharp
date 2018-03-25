using System;

namespace Cases
{
    public class Fibonacci
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("How many steps would you like to calc?");

            var MaxSteps = int.Parse(Console.ReadLine());
            var step = 0;

            Console.Clear();
            Console.WriteLine("Calculating {0} steps...", MaxSteps);

            while(step < MaxSteps)
            {
                Console.WriteLine(Calc(step));
                step++;
            }
        }

        private int Calc(int value)
        {
            return value < 2
                ? 1
                : Calc(value - 1) + Calc(value - 2);
        }
    }
}
