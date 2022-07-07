using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 5, 9, 9, 9, 5, 5 };
            int maxRepeat = 1;
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
                        maxRepeatTemp = 1;
                        number = numberTemp;
                        numberTemp = numbers[i];
                    }
                }
            }

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Number: {number}.");
            Console.WriteLine($"Max repeat: {maxRepeat}.");
        }
    }
}
