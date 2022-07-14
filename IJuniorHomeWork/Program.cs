using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings1 = new string[] { "1", "2", "1" };
            string[] strings2 = new string[] { "3", "2" };
            List<string> joinedStringCollection = new List<string>();

            foreach (string line in strings1)
            {
                if (joinedStringCollection.Contains(line) == false)
                {
                    joinedStringCollection.Add(line);
                }
            }

            foreach (string line in strings2)
            {
                if (joinedStringCollection.Contains(line) == false)
                {
                    joinedStringCollection.Add(line);
                }
            }

            foreach (string line in joinedStringCollection)
            {
                Console.Write(line + " ");
            }
        }
    }
}
