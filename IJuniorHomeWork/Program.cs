using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxRandom = 10;
            int arraySize = 30;
            int[] numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(maxRandom);
            }

            int maxRepeat = 0;
            int maxRepeatTemp = 1;
            int number = numbers[0];
            int numberTemp = numbers[0];

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numberTemp == numbers[i])
                {
                    maxRepeatTemp++;
                }
                else
                {
                    if (maxRepeatTemp > maxRepeat)
                    {
                        maxRepeat = maxRepeatTemp;
                        number = numberTemp;
                    }

                    maxRepeatTemp = 1;
                    numberTemp = numbers[i];
                }
            }

            foreach (int element in numbers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Number: {number}.");
            Console.WriteLine($"Max repeat: {maxRepeat}.");
        }
    }
}
