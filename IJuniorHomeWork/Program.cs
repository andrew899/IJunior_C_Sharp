using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map = new char[,] {
                                            { '=','=','=','=','=' },
                                            { '=',' ','=',' ','*' },
                                            { '=',' ','=',' ','=' },
                                            { '=',' ','=',' ','=' },
                                            { '=',' ',' ',' ','=' },
                                            { '=','=','=','=','=' }
                                          }; 

            char finishSymbol = '*';
            char wallSymbol = '=';
            char player = '@';
            int playerX = 1;
            int playerY = 1;
            bool exit = false;

            Game(ref map, ref player, ref playerX, ref playerY, finishSymbol, wallSymbol, exit);
        }

        private static void Game(ref char[,] map, ref char player, ref int playerX, ref int playerY, char finishSymbol, char wallSymbol, bool exit)
        {
            Console.WriteLine("W - Up, S - Down, A - Left, D - Right. = Wall, * Finish");

            while (exit == false)
            {
                if (PlayerWin(map, playerX, playerY, finishSymbol))
                {
                    Console.WriteLine("\nCongratulations. You WIN!!!");
                    break;
                }
                PrintMap(map, playerX, playerY, player);
                PlayerMove(ref playerX, ref playerY, ref exit, map, wallSymbol);
            }
        }

        private static void PlayerMove(ref int playerX, ref int playerY, ref bool exit, char[,] map, char wallSymbol)
        {
            int playerPositionX = playerX;
            int playerPositionY = playerY;
            var playerInput = Console.ReadKey().Key;

            switch (playerInput)
            {
                case ConsoleKey.W:
                    {
                        playerPositionY--;
                        break;
                    }

                case ConsoleKey.S:
                    {
                        playerPositionY++;
                        break;
                    }

                case ConsoleKey.A:
                    {
                        playerPositionX--;
                        break;
                    }

                case ConsoleKey.D:
                    {
                        playerPositionX++;
                        break;
                    }

                case ConsoleKey.Escape:
                    {
                        exit = true;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong input, W - Up, S - Down, A - Left, D - Right, ESC - Exit. = Wall, * Finish");
                        break;
                    }
            }

            if (map[playerPositionY, playerPositionX] != wallSymbol)
            {
                playerX = playerPositionX;
                playerY = playerPositionY;
            }
        }

        private static bool PlayerWin(char[,] map, int playerX, int playerY, char finishSymbol)
        {
            return map[playerY, playerX] == finishSymbol;
        }

        private static void PrintMap(char[,] map, int playerX, int playerY, char player)
        {
            int consoleCursoerLeft = 0;
            int consoleCursoreTop = 1;
            Console.SetCursorPosition(consoleCursoerLeft, consoleCursoreTop);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                    if (i == playerY && j == playerX)
                    {
                        Console.Write(player);
                        continue;
                    }

                    Console.Write(map[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
