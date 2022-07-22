using System;
using System.Collections.Generic;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersDB playersDB = new PlayersDB();
        }
    }

    class PlayersDB
    {
        private int _lastId;

        public PlayersDB()
        {
            List<Player> players = new List<Player>();
        }
    }

    class Player
    {
        private int _id;
        private string _name;
        private string _surname;
        private bool _IsBanned;

        public string Name => _name;
        public string SurName => _surname;
        public bool IsBanned => _IsBanned;

        Player(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = name;
            _IsBanned = false;
        }

        public void SetPlayerBann(bool bannFalg)
        {
            _IsBanned = bannFalg;
        }
    }
}
