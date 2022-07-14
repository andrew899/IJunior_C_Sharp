using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameJobPairs = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            bool exitMenu = false;
            string userInputMenu;

            nameJobPairs.Add("Billy Bones", "Pirate");
            nameJobPairs.Add("David Livesey", "Doctor");
            nameJobPairs.Add("Jim Hawkins", "Ship boy");
            nameJobPairs.Add("Tomath Bones", "Sailor");

            while (exitMenu == false)
            {
                Console.WriteLine("1. Add file.");
                Console.WriteLine("2. Print all files.");
                Console.WriteLine("3. Delete file by Name.");
                Console.WriteLine("4. Exit.");
                Console.Write("Choose: ");
                userInputMenu = Console.ReadLine();

                switch (userInputMenu)
                {
                    case "1":
                            AddFile(ref nameJobPairs);
                            break;

                    case "2":
                            PrintFileAll(nameJobPairs);
                            break;

                    case "3":
                            DeleteFileByName(ref nameJobPairs);
                            break;

                    case "4":
                            exitMenu = true;
                            break;

                    default:
                            Console.WriteLine("Wrong input.");
                            break;
                }
            }
        }

        private static void AddFile(ref Dictionary<string, string> namesJobsPairs)
        {
            string nameInput;
            string jobPositionInput;

            Console.Write("Enter name: ");
            nameInput = Console.ReadLine();
            Console.Write("Enter job position: ");
            jobPositionInput = Console.ReadLine();

            namesJobsPairs.Add(nameInput, jobPositionInput);
        }

        private static void PrintFileAll(Dictionary<string, string> namesJobsPairs)
        {
            int borderLength = 30;
            string borderString = new string('=', borderLength);
            Console.WriteLine(borderString);

            if (namesJobsPairs.Count == 0)
            {
                Console.WriteLine("There is no employees.");
                return;
            }

            foreach (var nameJobPair in namesJobsPairs)
            {
                Console.WriteLine($"{nameJobPair.Key} - {nameJobPair.Value}");
            }

            Console.WriteLine(borderString);
        }

        private static void DeleteFileByName(ref Dictionary<string, string> namesJobsPairs)
        {
            string userInputName;
            Console.Write("Enter Name: ");
            userInputName = Console.ReadLine();

            if (namesJobsPairs.ContainsKey(userInputName))
            {
                namesJobsPairs.Remove(userInputName);
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}
