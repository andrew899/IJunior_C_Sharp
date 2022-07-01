using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pupkin";
            string surname = "Vasya";

            Console.WriteLine("Default:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}\n");

            string temp = name;
            name = surname;
            surname = temp;

            Console.WriteLine("After switch places:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}\n");
        }
    }
}
