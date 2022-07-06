using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 3;

            int numberOfLine = 1;
            int numberOfColumn = 0;
            int sum = 0;
            int resultMultiplication = 1;

            int[,] ints = { { 1, 1, 1 }, 
                            { 1, 1, 1 }, 
                            { 1, 1, 1 } };

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    sum += ints[numberOfLine,j];

                    Console.Write(ints[i, j] + " ");
                }
                resultMultiplication *= ints[i,numberOfColumn];
                Console.WriteLine();
            }

            Console.WriteLine($"Sum: {sum}.");
            Console.WriteLine($"Multiplication: {resultMultiplication}");
        }
    }
}
