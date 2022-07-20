using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Vasya";
            string surname = "Pupkin";
            int positionX = 1;
            int positionY = 1;
            Player player = new Player(name, surname, positionX, positionY);
            Renderer renderer = new Renderer();

            renderer.PrintPlayer(player.GetPlayerPositionX(), player.GetPlayerPositionY());
        }
    }

    internal class Renderer
    {
        Lazy
        public Renderer()
        {
        }

        internal void PrintPlayer(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

    internal class Player
    {
        private string _name;
        private string _surname;
        private int _positionX;
        private int _positionY;

        public Player(string name, string surname, int positionX, int positionY)
        {
            _name = name;
            _surname = surname;
            _positionX = positionX;
            _positionY = positionY;
        }

        public int GetPlayerPositionX() => _positionX;
        public int GetPlayerPositionY() => _positionY;
    }
}
