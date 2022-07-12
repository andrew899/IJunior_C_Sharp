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

            StartDictionary(wordDictionary);
        }

        private static void StartDictionary(Dictionary<string, string> wordDictionary)
        {
            bool exit = false;
            string userInput;
            while (exit == false)
            {
                int menuItem;

                Console.WriteLine("Dictionary.");
                Console.WriteLine("1. Entet word.");
                Console.WriteLine("2. Exit.");

                if (Int32.TryParse(Console.ReadLine(), out menuItem) == false)
                {
                    Console.WriteLine("Try again.");
                }

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("Enter word:");
                            userInput = Console.ReadLine();

                            if (wordDictionary.ContainsKey(userInput) == false)
                            {
                                Console.WriteLine("Sorry, Dicionary does not know this word.");
                                continue;
                            }

                            foreach (var dictionaryEntry in wordDictionary)
                            {
                                if (dictionaryEntry.Key.ToLower() == userInput.ToLower())
                                {
                                    Console.WriteLine(dictionaryEntry.Key + " - " + dictionaryEntry.Value);
                                }
                            }

                            break;
                        }

                    case 2:
                        {
                            exit = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Wrong number. Try again.");
                            break;
                        }
                }
            }
        }
    }
}
