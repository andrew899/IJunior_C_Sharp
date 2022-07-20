using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vasya";
            var surname = "Pupkin";
            Player player = new Player(name, surname);

            Console.WriteLine($"Player name: {player.GetName()}.");
            Console.WriteLine($"Player surname: {player.GetSurname()}.");
            Console.WriteLine($"Player name: {player.GetFullName()}.");
        }
    }
}
