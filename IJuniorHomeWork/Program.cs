using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameJobPairs = new Dictionary<string, string> { }
            string[] names = new string[] { "Billy Bones", "David Livesey", "Jim Hawkins", "Tomath Bones", };
            string[] jobPositions = new string[] { "Pirate", "Doctor", "Ship boy", "Sailor" };
            bool exitMenu = false;
            string userInputMenu;

            while (exitMenu == false)
            {
                Console.WriteLine("1. Add file.");
                Console.WriteLine("2. Print all files.");
                Console.WriteLine("3. Delete file by index.");
                Console.WriteLine("4. Find by Surname");
                Console.WriteLine("5. Exit.");
                Console.Write("Choose: ");
                userInputMenu = Console.ReadLine();

                switch (userInputMenu)
                {
                    case "1":
                            AddFile(ref names, ref jobPositions);
                            break;

                    case "2":
                            PrintFileAll(names, jobPositions);
                            break;

                    case "3":
                            DeleteFileByIndex(ref names, ref jobPositions);
                            break;

                    case "4":
                            PrintFileBySurname(names, jobPositions);
                            break;

                    case "5":
                            exitMenu = true;
                            break;

                    default:
                            Console.WriteLine("Wrong input.");
                            break;
                }
            }
        }

        private static void AddFile(ref string[] names, ref string[] jobPositions)
        {
            string nameInput;
            string jobPositionInput;

            Console.Write("Enter name: ");
            nameInput = Console.ReadLine();
            Console.Write("Enter job position: ");
            jobPositionInput = Console.ReadLine();

            AddFileToArray(ref names, nameInput);
            AddFileToArray(ref jobPositions, jobPositionInput);
        }

        private static void AddFileToArray(ref string[] array, string itemToAdd)
        {
            string[] tempNames = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempNames[i] = array[i];
            }

            tempNames[array.Length] = itemToAdd;
            array = tempNames;
        }

        private static void PrintFileAll(string[] names, string[] jobPositions)
        {
            int borderLength = 30;
            string borderString = new string('=', borderLength);
            Console.WriteLine(borderString);

            if (names.Length == 0)
            {
                Console.WriteLine("There is no employees.");
                return;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} - {jobPositions[i]}");
            }

            Console.WriteLine(borderString);
        }

        private static void PrintFileBySurname(string[] names, string[] jobPositions)
        {
            bool nameFound = false;
            string userInputSurname;

            Console.Write("Enter Surname: ");
            userInputSurname = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Contains(userInputSurname.ToLower()))
                {
                    nameFound = true;
                    Console.WriteLine($"{i}. {names[i]} - {jobPositions[i]}");
                }
            }

            if (nameFound == false)
            {
                Console.WriteLine("No matches found.");
            }
        }

        private static void DeleteFileByIndex(ref string[] names, ref string[] jobPositions)
        {
            int userInputIndex;
            Console.Write("Enter Index: ");

            if (Int32.TryParse(Console.ReadLine(), out userInputIndex))
            {
                userInputIndex--;

                if (userInputIndex < names.Length)
                {
                    DeleteItemInArrayByIndex(userInputIndex, ref names);
                    DeleteItemInArrayByIndex(userInputIndex, ref jobPositions);
                }
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }

        private static void DeleteItemInArrayByIndex(int indexToDelete, ref string[] array)
        {
            string[] tempNames = new string[array.Length - 1];

            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (i == indexToDelete)
                {
                    i++;
                }

                tempNames[j] = array[i];
            }

            array = tempNames;
        }
    }
}
