using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int min = 1;
            int max = 28;
            int number = random.Next(min, max);
            int amountOfMultiplies = 0;
            int length = 1000;
            
            for (int i = 0; i < length; i += number)
            {
                if(i >= 100)
                {
                    amountOfMultiplies += 1;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Number: {number}, has {amountOfMultiplies} amount of 3-digit multiplies");
        }
    }
}
