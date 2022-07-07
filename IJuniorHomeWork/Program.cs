using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcReturn = ReadInt();

            Console.WriteLine($"You enter: {funcReturn}");
        }

        private static int ReadInt()
        {
            int userInput = 0;

            Console.Write("Enter number: ");

            while (Int32.TryParse(Console.ReadLine(), out userInput) == false)
            {
                Console.Write("Incorrect input. Try again: ");
            }

            return userInput;
        }
    }
}
