using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullHealth = 10;
            int health = 4;

            PrintHealth(health, fullHealth);
        }

        private static void PrintHealth(int health, int fullHealth)
        {
            Console.Write("Health [");

            while (fullHealth-- >= 0)
            {
                if (health-- >= 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("_");
                }
            }
            
            Console.Write("]");
        }
    }
}
