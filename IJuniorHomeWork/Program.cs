using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForSplit = "Given a string with text, using the String.Split() string method, " +
                                    "get an array of words that are separated by a space in the text and output the array, each word on a new line.";
            string[] splitStrings = stringForSplit.Split(' ');

            Console.WriteLine(stringForSplit);
            Console.WriteLine("\nSplited:");

            foreach (var item in splitStrings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
