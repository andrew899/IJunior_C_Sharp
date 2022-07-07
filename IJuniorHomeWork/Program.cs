using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxRandom = 100;
            int arraySize = 30;
            int[] ints = new int[arraySize];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(maxRandom);
            }

            Console.WriteLine("Unsorted: ");
            foreach (int number in ints)
            {
                Console.Write(number + " ");
            }

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length - 1; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        int tempNumber = ints[j + 1];
                        ints[j + 1] = ints[j];
                        ints[j] = tempNumber;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Bubble sort: ");
            foreach (int number in ints)
            {
                Console.Write(number + " ");
            }
        }
    }
}
