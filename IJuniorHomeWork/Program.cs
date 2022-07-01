using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(100);
            Console.WriteLine($"Number = {number}");

            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i%2 == 0 && (i%3 == 0 || i%5 == 0))
                {
                    Console.WriteLine(i);
                    sum += i; 
                }
            }

            Console.WriteLine($"Sum = {sum} ");
        }
    }
}
