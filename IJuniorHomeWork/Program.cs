using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next();

            int exponentNumber = 2;
            int exponentIndex = 1;
            int exponentResult = 2;

            while (exponentResult <= number)
            {
                exponentResult *= exponentNumber;
                exponentIndex += 1;
            }

            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Exponent index: {exponentIndex}");
            Console.WriteLine($"Exponent result: {exponentResult}");

        }
    }
}
