using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static string[] names = new string[] {"Billy Bones", "David Livesey", "Jim Hawkins", "Tomath Bones", };
        static string[] jobPositions = new string[] {"Pirate", "Doctor", "Ship boy", "Sailor"};

        static void Main(string[] args)
        {
            bool exitMune = false;
            int borderLength = 30;
            string borderString = new string('=', borderLength);
            string userInputMenu;

            while (exitMune == false)
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
                        {
                            AddFile();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine(borderString);
                            PrintFileAll();
                            Console.WriteLine(borderString);
                            break;
                        }

                    case "3":
                        {
                            int userInputIndex;
                            Console.Write("Enter Index: ");
                            if(Int32.TryParse(Console.ReadLine(), out userInputIndex))
                            {
                                userInputIndex--;
                                if(userInputIndex < names.Length)
                                {
                                    DeleteFileByIndex(userInputIndex);
                                }
                                Console.WriteLine(borderString);
                                break;
                            }
                            Console.WriteLine("Wrong input.");
                            break;
                        }

                    case "4":
                        {
                            string userInputSurname;
                            Console.WriteLine(borderString);
                            Console.Write("Enter Surname: ");
                            userInputSurname = Console.ReadLine();
                            PrintFileBySurname(userInputSurname);
                            Console.WriteLine(borderString);
                            break;
                        }

                    case "5":
                        {
                            exitMune = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine(borderString);
                            Console.WriteLine("Wrong input.");
                            Console.WriteLine(borderString);
                            break;
                        }

                }
            }
        }

        private static void AddFile()
        {
            string nameInput;
            string jobPositionInput;

            Console.Write("Enter name: ");
            nameInput = Console.ReadLine();
            Console.Write("Enter job position: ");
            jobPositionInput = Console.ReadLine();

            AddName(nameInput);
            AddJobPosition(jobPositionInput);
        }

        private static void AddName(string nameToAdd)
        {
            string[] tempNames = new string [names.Length + 1];

            for (int i = 0; i < names.Length; i++)
            {
                tempNames[i] = names[i];
            }

            tempNames[names.Length] = nameToAdd;
            names = tempNames;
        }

        private static void AddJobPosition(string jobPositionToAdd)
        {
            string[] tempJobs = new string[jobPositions.Length + 1];

            for (int i = 0; i < jobPositions.Length; i++)
            {
                tempJobs[i] = jobPositions[i];
            }

            tempJobs[jobPositions.Length] = jobPositionToAdd;
            jobPositions = tempJobs;
        }

        private static void PrintFileAll()
        {
            if(names.Length == 0)
            {
                Console.WriteLine("There is no employees.");
                return;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} - {jobPositions[i]}");
            }
        }

        private static void PrintFileBySurname(string surname)
        {
            bool nameFound = false;

            for (int i = 0; i < names.Length; i++)
            {
                if(names[i].ToLower().Contains(surname.ToLower()))
                {
                    nameFound = true;
                    Console.WriteLine($"{i}. {names[i]} - {jobPositions[i]}");
                }
            }

            if(nameFound == false)
            {
                Console.WriteLine("No matches found.");
            }
        }

        private static void DeleteFileByIndex(int userIndex)
        {
            DeleteNameByIndex(userIndex);
            DeleteJobPositionByIndex(userIndex);
        }

        private static void DeleteNameByIndex(int userIndex)
        {
            string[] tempNames = new string[names.Length - 1];

            for (int i = 0, j = 0; i < names.Length; i++, j++)
            {
                if(i == userIndex)
                {
                    i++;
                }

                tempNames[j] = names[i];
            }

            names = tempNames;
        }

        private static void DeleteJobPositionByIndex(int userIndex)
        {
            string[] tempJobPositions = new string[jobPositions.Length - 1];

            for (int i = 0, j = 0; i < jobPositions.Length; i++, j++)
            {
                if (i == userIndex)
                {
                    i++;
                }
                
                tempJobPositions[j] = jobPositions[i];
            }

            jobPositions = tempJobPositions;
        }
    }
}
