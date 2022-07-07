using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 3, 4 };
            int amountOfShift = 0;

            Console.WriteLine("Original array: ");
            foreach (int element in ints)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.Write("Enter amount of shifts: ");
            
            while(Int32.TryParse(Console.ReadLine(), out amountOfShift) == false)
            {
                Console.Write("Incorrect number. Try again: ");
            }          

            while (amountOfShift-- > 0)
            {
                int firstElement = ints[0];

                for (int i = 0; i < ints.Length - 1; i++)
                {
                    ints[i] = ints[i + 1];
                }

                ints[ints.Length - 1] = firstElement;

                foreach (int element in ints)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
                
                Console.WriteLine($"Shift left: {amountOfShift}.");
            }
        }
    }
}
