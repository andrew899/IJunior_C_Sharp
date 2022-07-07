using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int functionReturnNumber = ReadInt();

            Console.WriteLine($"You enter: {functionReturnNumber}");
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
