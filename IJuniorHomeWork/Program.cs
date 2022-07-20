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

            Console.WriteLine($"Player fullname: {player.GetFullName()}.");
        }
    }

    class Player
    {
        private string _name;
        private string _surname;

        public Player(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public string GetFullName() => _name + " " + _surname;
    }
}
