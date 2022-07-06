using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLine = 1;
            int numberOfColumn = 0;
            int sum = 0;
            int resultMultiplication = 1;

            int[,] ints = { { 1, 2, 3 }, 
                            { 1, 1, 1 }, 
                            { 7, 8, 9 } };

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (j == numberOfColumn)
                        resultMultiplication *= ints[i,j];

                    if (i == numberOfLine)
                        sum += ints[i,j];

                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Sum: {sum}.");
            Console.WriteLine($"Multiplication: {resultMultiplication}");
        }
    }
}
