using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersDB playersDB = new PlayersDB();

            bool isWorking = true;
            int userIdInput;
            bool playerBannFlag;

            playersDB.AddPlayer("Vasya", "Pupkin");
            playersDB.AddPlayer("Jhon", "Smit");
            playersDB.AddPlayer("Samson", "Herkules");
            playersDB.AddPlayer("Diatel", "Scvorcov");

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
                        string name;
                        string surname;

                        Console.Write("Enter Player Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Player Surname: ");
                        surname = Console.ReadLine();

                        playersDB.AddPlayer(name, surname);

                        break;

                    case "2":
                        playersDB.PrintAllPlayers();

                        break;

                    case "3":
                        playerBannFlag = true;
                        Console.Write("Enter Player Id: ");
                        
                        SetPlayerBannFlag(playersDB, playerBannFlag);

                        break;

                    case "4":

                        playerBannFlag = false;

                        Console.Write("Enter Player Id: ");

                        SetPlayerBannFlag(playersDB, playerBannFlag);

                        break;

                    case "5":

                        Console.Write("Enter Player Id: ");

                        if (Int32.TryParse(Console.ReadLine(), out userIdInput))
                        {
                            if (playersDB.DeletePlayerById(userIdInput) == false)
                            {
                                Console.WriteLine($"No Player with Id: {userIdInput}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Id input. Must be integer.");
                        }

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

        private static void SetPlayerBannFlag(PlayersDB playersDB, bool playerBannFlag)
        {
            int userIdInput;

            if (Int32.TryParse(Console.ReadLine(), out userIdInput))
            {
                if (playersDB.SetBannPlayerFlagById(userIdInput, playerBannFlag) == false)
                {
                    Console.WriteLine($"No Player with Id: {userIdInput}.");
                }
            }
            else
            {
                Console.WriteLine("Wrong Id input. Must be integer.");
            }
        }
    }

    class PlayersDB
    {
        private int _lastId = 0;
        private List<Player> _players = new List<Player>();

        public void AddPlayer(string name, string surname)
        {
            _players.Add(new Player(_lastId++, name, surname));
        }

        public bool DeletePlayerById(int playerId)
        {
            bool result = false;

            foreach (Player player in _players)
            {
                if(player.Id == playerId)
                {
                    result = _players.Remove(player);
                }
            }

            return result;
        }

        public bool SetBannPlayerFlagById(int playerId, bool bannFlag)
        {
            bool result = false;
            foreach (Player player in _players)
            {
                if (player.Id == playerId)
                {
                    player.SetPlayerBann(bannFlag);
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void PrintAllPlayers()
        {
            foreach (Player player in _players)
            {
                Console.WriteLine($"Player Id: {player.Id}. Fullname: {player.GetFullName()}. BannFlag: {player.IsBanned};");
            }
        }
    }

    class Player
    {
        private int _id;
        private string _name;
        private string _surname;
        private bool _IsBanned;

        public int Id => _id;
        public string Name => _name;
        public string SurName => _surname;
        public bool IsBanned => _IsBanned;

        public Player(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _IsBanned = false;
        }

        public string GetFullName() => _name + " " + _surname;

        public void SetPlayerBann(bool newBannFalg)
        {
            _IsBanned = newBannFalg;
        }
    }
}
