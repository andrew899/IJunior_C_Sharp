using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Database Database = new Database();

            bool isWorking = true;

            Database.AddPlayer("Vasya", "Pupkin");
            Database.AddPlayer("Jhon", "Smit");
            Database.AddPlayer("Samson", "Herkules");
            Database.AddPlayer("Diatel", "Scvorcov");

            while (isWorking)
            {
                Console.WriteLine("1. Add new Player.");
                Console.WriteLine("2. Print all Players.");
                Console.WriteLine("3. Bann Player by Id.");
                Console.WriteLine("4. Unbann Player by Id.");
                Console.WriteLine("5. Delete Player by Id.");
                Console.WriteLine("6. Exit.");
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Database.AddPlayer();
                        break;

                    case "2":
                        Database.PrintAllPlayers();
                        break;

                    case "3":

                        Database.BannPlayer();
                        break;

                    case "4":

                        Database.UnBannPlayer();
                        break;

                    case "5":

                        Database.DeletePlayerById();
                        break;

                    case "6":
                        isWorking = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        }
    }

    class Database
    {
        private int _lastId = 0;
        private List<Player> _players = new List<Player>();

        public void AddPlayer()
        {
            string name;
            string surname;

            Console.Write("Enter Player Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Player Surname: ");
            surname = Console.ReadLine();

            _players.Add(new Player(_lastId++, name, surname));
        }

        public void AddPlayer(string name, string surname)
        {
            _players.Add(new Player(_lastId++, name, surname));
        }

        public bool DeletePlayerById()
        {
            bool result = false;
            Player player;

            if (TryGetPlayer(out player))
            {
                _players.Remove(player);
            }

            return result;
        }

        public void PrintAllPlayers()
        {
            foreach (Player player in _players)
            {
                Console.WriteLine($"Player Id: {player.Id}. Fullname: {player.GetFullName()}. BannFlag: {player.HasBann};");
            }
        }

        internal void BannPlayer()
        {
            Player player;

            if (TryGetPlayer(out player))
            {
                player.Bann();
            }
        }

        internal void UnBannPlayer()
        {
            Player player;

            if (TryGetPlayer(out player))
            {
                player.UnBann();
            }
        }

        private bool TryGetPlayer (out Player playerOut)
        {
            bool result = false;
            playerOut = null;
            Console.Write("Enter Player Id: ");

            if (Int32.TryParse(Console.ReadLine(), out int userIdInput))
            {
                foreach (Player player in _players)
                {
                    if (player.Id == userIdInput)
                    {
                        playerOut = player;
                        result = true;
                        break;
                    }
                }

                Console.WriteLine("Wrong Id.");
            }
            else
            {
                Console.WriteLine("Wrong Id input.");
            }

            return result;
        }
    }

    class Player
    {
        private int _id;
        private string _name;
        private string _surname;
        public bool HasBann { get; private set; }

        public int Id => _id;
        public string Name => _name;
        public string SurName => _surname;

        public Player(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = surname;
            HasBann = false;
        }

        public string GetFullName() => _name + " " + _surname;

        public void Bann()
        {
            HasBann = true;
        }

        public void UnBann()
        {
            HasBann = false;
        }
    }
}
