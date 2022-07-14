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
            HashSet<string> joinedStringCollection = new HashSet<string>();

            AddUniqueElementInColectio(joinedStringCollection, strings1);
            AddUniqueElementInColectio(joinedStringCollection, strings2);
            PrintColection(joinedStringCollection);
            
        }

        private static void AddUniqueElementInColectio(HashSet<string> colectionToInsetIn, string[] arrayToAdd)
        {
            foreach (string element in arrayToAdd)
            {
                colectionToInsetIn.Add(element);
            }
        }

        private static void PrintColection(HashSet<string> collectionToPrint)
        {
            foreach (string elemet in collectionToPrint)
            {
                Console.Write(elemet + " ");
            }
        }
    }
}
