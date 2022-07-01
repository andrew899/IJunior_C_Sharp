using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 100;
            int numberForCheck1 = 3;
            int numberForCheck2 = 5;
            int sum = 0;

            Random random = new Random();
            int number = random.Next(maxNumber);
            Console.WriteLine($"Number = {number}");

            for (int i = 0; i <= number; i++)
            {
                if (i%numberForCheck1 == 0 || i%numberForCheck2 == 0)
                {
                    Console.WriteLine(i);
                    sum += i; 
                }
            }

            Console.WriteLine($"Sum = {sum} ");
        }
    }
}
