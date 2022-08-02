using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            bool isWorking = true;

            database.AddPlayer("Vasya", "Pupkin");
            database.AddPlayer("Jhon", "Smit");
            database.AddPlayer("Samson", "Herkules");
            database.AddPlayer("Diatel", "Scvorcov");

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
                        database.AddPlayer();
                        break;

                    case "2":
                        database.PrintAllPlayers();
                        break;

                    case "3":

                        database.BannPlayer();
                        break;

                    case "4":

                        database.UnBannPlayer();
                        break;

                    case "5":

                        database.DeletePlayerById();
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
        private int _lastUsedId = 0;
        private List<Player> _players = new List<Player>();

        public void AddPlayer()
        {
            string name;
            string surname;

            Console.Write("Enter Player Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Player Surname: ");
            surname = Console.ReadLine();

            _players.Add(new Player(_lastUsedId++, name, surname));
        }

        public void AddPlayer(string name, string surname)
        {
            _players.Add(new Player(_lastUsedId++, name, surname));
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
                        return result;
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
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public bool HasBann { get; private set; }

        public Player(int idIn, string nameIn, string surnameIn)
        {
            Id = idIn;
            Name = nameIn;
            Surname = surnameIn;
            HasBann = false;
        }

        public string GetFullName() => Name + " " + Surname;

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
