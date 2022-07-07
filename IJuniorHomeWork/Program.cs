using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] {1, 2, 3, 4, 5 };

            PrintArray(ints);
            var intsShufeled = Shufle(ints);
            PrintArray(intsShufeled);
        }

        private static int[] Shufle(int[] ints)
        {
            Random random = new Random();
            int[] tempArray = ints;

            for (int i = tempArray.Length - 1; i >= 1 ; i--)
            {
                int randomPosition = random.Next(i + 1);
                int tempNumber = ints[randomPosition];
                ints[randomPosition] = ints[i];
                ints[i] = tempNumber;
            }

            return tempArray;
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
