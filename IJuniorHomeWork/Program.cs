using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] {1, 2, 3, 4, 5 };

            PrintArray(ints);
            Shufle(ints);
            PrintArray(ints);
        }

        private static void Shufle(int[] ints)
        {
            Random random = new Random();

            for (int i = ints.Length - 1; i >= 1 ; i--)
            {
                int randomPosition = random.Next(i + 1);
                int tempNumber = ints[randomPosition];
                ints[randomPosition] = ints[i];
                ints[i] = tempNumber;
            }
        }

        private static void PrintArray(int[] ints)
        {
            foreach (int element in ints)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
