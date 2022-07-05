using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter char for border: ");
            char borderChar = Console.ReadKey().KeyChar;
            Console.Write("\nEnter user string: ");
            string userString = Console.ReadLine();

            int amountOfStrings = 3;
            int stringNumberForUserString = 2;
            int borderLenth = 4;

            int lenthUserString = userString.Length;
            int stringLenth = borderLenth + lenthUserString;
            string borderString = new string(borderChar, stringLenth);

            for (int i = 1; i <= amountOfStrings; i++)
            {
                if (i == stringNumberForUserString)
                {
                    Console.WriteLine(borderChar + " " + userString + " " + borderChar);
                }
                else
                {
                    Console.WriteLine(borderString);
                }
            }
        }
    }
}
