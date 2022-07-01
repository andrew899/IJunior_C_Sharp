using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "pass";
            string message = "Secret message!!!";
            int amountOfTries = 3;

            while (amountOfTries-- != 0)
            {
                Console.Write("Enter password: ");
                string userInput = Console.ReadLine().ToLower();

                if (password.Equals(userInput))
                {
                    Console.WriteLine(message);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password. Try again.");
                }
            }
        }
    }
}
