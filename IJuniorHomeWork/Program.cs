using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> personal = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            bool isExit = false;
            string userInputMenu;

            personal.Add("Billy Bones", "Pirate");
            personal.Add("David Livesey", "Doctor");
            personal.Add("Jim Hawkins", "Ship boy");
            personal.Add("Tomath Bones", "Sailor");

            while (isExit == false)
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
                            AddFile(personal);
                            break;

                    case "2":
                            PrintFileAll(personal);
                            break;

                    case "3":
                            DeleteFileByName(personal);
                            break;

                    case "4":
                            isExit = true;
                            break;

                    default:
                            Console.WriteLine("Wrong input.");
                            break;
                }
            }
        }

        private static void AddFile(Dictionary<string, string> personal)
        {
            string nameInput;
            string jobPositionInput;

            Console.Write("Enter name: ");
            nameInput = Console.ReadLine();
            
            if (personal.ContainsKey(nameInput))
            {
                Console.WriteLine($"{nameInput} alredy exist.");
                return;
            }

            Console.Write("Enter job position: ");
            jobPositionInput = Console.ReadLine();

            personal.Add(nameInput, jobPositionInput);
        }

        private static void PrintFileAll(Dictionary<string, string> personal)
        {
            int borderLength = 30;
            string borderString = new string('=', borderLength);
            Console.WriteLine(borderString);

            if (personal.Count == 0)
            {
                Console.WriteLine("There is no employees.");
                return;
            }

            foreach (var nameJobPair in personal)
            {
                Console.WriteLine($"{nameJobPair.Key} - {nameJobPair.Value}");
            }

            Console.WriteLine(borderString);
        }

        private static void DeleteFileByName(Dictionary<string, string> personal)
        {
            string userInputName;
            Console.Write("Enter Name: ");
            userInputName = Console.ReadLine();

            if (personal.ContainsKey(userInputName))
            {
                personal.Remove(userInputName);
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}
