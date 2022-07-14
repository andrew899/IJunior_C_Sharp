using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "Dictionary", "A book or electronic resource that lists the words of a language." },
                { "Monitor", "An instrument or device used for observing, checking, or keeping a continuous record of a process or quantity." },
                { "Game", "A form of play or sport, especially a competitive one played according to rules and decided by skill, strength, or luck." },
                { "Remote", "A remote control device." },
                { "System", "A set of things working together as parts of a mechanism or an interconnecting network." },
                { "Word", "A single distinct meaningful element of speech or writing." }
            };
            bool exit = false;
            string userInput;

            while (exit == false)
            {
                string menuItem;

                Console.WriteLine("Dictionary.");
                Console.WriteLine("1. Entet word.");
                Console.WriteLine("2. Exit.");
                menuItem = Console.ReadLine();

                switch (menuItem)
                {
                    case "1":
                            Console.Write("Enter word:");
                            userInput = Console.ReadLine();

                            if (wordDictionary.ContainsKey(userInput) == false)
                            {
                                Console.WriteLine("Sorry, Dicionary does not know this word.");
                                break;
                            }

                            Console.WriteLine(wordDictionary[userInput]);
                            break;

                    case "2":
                            exit = true;
                            break;

                    default:
                            Console.WriteLine("Wrong number. Try again.");
                            break;
                } 
            }
        }
    }
}
