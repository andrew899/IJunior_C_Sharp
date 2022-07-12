using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            List<int> numbers = new List<int>();
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Enter number to add to array.\n" +
                                  "Enter SUM to get sum of all numbers in array.\n" +
                                  "Enter EXIT to close program.");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "sum":
                        {
                            int sum = 0;
                            foreach (int number in numbers)
                            {
                                sum += number;
                            }

                            Console.WriteLine($"Sum: {sum}");
                            break;
                        }
                    case "exit":
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            int inputNumber = 0;

                            if (Int32.TryParse(userInput, out inputNumber))
                            {
                                numbers.Add(inputNumber);
                            }
                            else
                            {
                                Console.WriteLine("Unknown input. Try again.");
                            }

                            break;
                        }
                }

                Console.WriteLine();
            }
        }
    }
}
