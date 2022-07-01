using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 7;
            int start = 5;
            int end = 100;

            for (int i = start; i < end; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
