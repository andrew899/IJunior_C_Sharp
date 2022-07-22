﻿using System;

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

            renderer.PrintPlayer(player.positionX, player.positionY);
        }
    }

    class Renderer
    {
        public void PrintPlayer(int playerX, int playerY)
        {
            Console.WriteLine($"Player X: {playerX}. Player Y: {playerY}"); ;
        }
    }

    class Player
    {
        private string _name;
        private string _surname;
        public int positionX { get; private set; }
        public int positionY { get; private set; }

        public Player(string name, string surname, int positionX, int positionY)
        {
            _name = name;
            _surname = surname;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public string GetFullName() => _name + " " + _surname;
    }
}
