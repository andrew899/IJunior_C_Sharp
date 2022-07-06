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

            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nLocal maximum: ");
            for (int i = 0; i < ints.Length; i++)
            {
                if (i == firstElement)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        Console.WriteLine(ints[i]);
                    }
                }
                else if (i == lastElement)
                {
                    if (ints[i] > ints[i - 1])
                    {
                        Console.WriteLine(ints[i]);
                    }
                }
                else if (ints[i] > ints[i - 1] && ints[i] > ints[i + 1])
                {
                    Console.WriteLine(ints[i]);
                }
            }
        }
    }
}
