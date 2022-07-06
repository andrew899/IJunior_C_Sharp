using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomMax = 10;
            int arraySize = 30;
            int[] ints = new int[arraySize];
            int firstElement = 0;
            int lastElement = ints.Length - 1;

            for (int i = 0; i < arraySize; i++)
            {
                ints[i] = random.Next(randomMax + 1);
            }

            foreach (int element in ints)
            {
                Console.Write(element + " ");
            }

            if (ints[firstElement] > ints[firstElement + 1])
            {
                Console.WriteLine(ints[firstElement]);
            }

            if (ints[lastElement] > ints[lastElement - 1])
            {
                Console.WriteLine(ints[lastElement]);
            }

            Console.WriteLine("\nLocal maximum: ");
            for (int i = firstElement + 1; i < lastElement; i++)
            {
                if (ints[i] > ints[i - 1] && ints[i] > ints[i + 1])
                {
                    Console.WriteLine(ints[i]);
                }
            }
        }
    }
}
