using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int[] numbers = new int[0];
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
                                int[] tempArray = new int[numbers.Length + 1];

                                for (int i = 0; i < numbers.Length; i++)
                                {
                                    tempArray[i] = numbers[i];
                                }

                                tempArray[numbers.Length] = inputNumber;
                                numbers = tempArray;
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
