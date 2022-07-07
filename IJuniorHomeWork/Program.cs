using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullHealth = 10;
            int health = 4;

            PrintBar(health, fullHealth);
        }

        private static void PrintBar(int activePart, int fullBarSize, char activeSymbol = '#', char emptySymbol = '_')
        {
            Console.Write("[");

            while (fullBarSize-- >= 0)
            {
                if (activePart-- >= 0)
                {
                    Console.Write(activeSymbol);
                }
                else
                {
                    Console.Write(emptySymbol);
                }
            }
            
            Console.Write("]");
        }
    }
}
