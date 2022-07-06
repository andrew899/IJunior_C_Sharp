using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;
            int[,] ints = new int[arraySize,arraySize];
            int maxElement = 0;
            int elementForOutput = 0;
            int minRamdom = 1;
            int maxRandom = 10;

            Random random = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i,j] = random.Next(minRamdom, maxRandom + 1);
                }
            }

            Console.WriteLine("Original matrix:");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i,j] > maxElement)
                    {
                        maxElement = ints[i,j];
                    }

                    Console.Write(ints[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nMax element: {maxElement}.\n");
            Console.WriteLine("Changed matrix: ");

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] == maxElement)
                    {
                        Console.Write(elementForOutput + " ");
                        continue;
                    }

                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
