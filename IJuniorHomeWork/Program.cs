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
            int playerPositionX = 1;
            int playerPositionY = 1;
            bool isExit = false;

            StartGame(ref map, ref player, ref playerPositionX, ref playerPositionY, finishSymbol, wallSymbol, isExit);
        }

        private static void StartGame(ref char[,] map, ref char player, ref int playerX, ref int playerY, char finishSymbol, char wallSymbol, bool isExit)
        {
            Console.WriteLine("W - Up, S - Down, A - Left, D - Right. = Wall, * Finish");

            while (isExit == false)
            {
                if (CheckWin(map, playerX, playerY, finishSymbol))
                {
                    Console.WriteLine("\nCongratulations. You WIN!!!");
                    break;
                }
                PrintMap(map, playerX, playerY, player);
                PlayerMove(ref playerX, ref playerY, ref isExit, map, wallSymbol);
            }
        }

        private static void PlayerMove(ref int playerPositionX, ref int playerPositionY, ref bool isExit, char[,] map, char wallSymbol)
        {
            int playerNewPositionX = playerPositionX;
            int playerNewPositionY = playerPositionY;
            var playerInput = Console.ReadKey().Key;

            switch (playerInput)
            {
                case ConsoleKey.W:
                    {
                        playerNewPositionY--;
                        break;
                    }

                case ConsoleKey.S:
                    {
                        playerNewPositionY++;
                        break;
                    }

                case ConsoleKey.A:
                    {
                        playerNewPositionX--;
                        break;
                    }

                case ConsoleKey.D:
                    {
                        playerNewPositionX++;
                        break;
                    }

                case ConsoleKey.Escape:
                    {
                        isExit = true;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong input, W - Up, S - Down, A - Left, D - Right, ESC - Exit. = Wall, * Finish");
                        break;
                    }
            }

            if (map[playerNewPositionY, playerNewPositionX] != wallSymbol)
            {
                ChagePlayerPosition(ref playerPositionX, ref playerPositionY, playerNewPositionX, playerNewPositionY);
            }
        }

        private static void ChagePlayerPosition(ref int playerPositionX, ref int playerPositionY, int playerNewPositionX, int playerNewPositionY)
        {
            playerPositionX = playerNewPositionX;
            playerPositionY = playerNewPositionY;
        }

        private static bool CheckWin(char[,] map, int playerPositionX, int playerPositionY, char finishSymbol)
        {
            return map[playerPositionY, playerPositionX] == finishSymbol;
        }

        private static void PrintMap(char[,] map, int playerPositionX, int playerPositionY, char player)
        {
            int consoleCursoerLeft = 0;
            int consoleCursoreTop = 1;
            Console.SetCursorPosition(consoleCursoerLeft, consoleCursoreTop);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                    if (i == playerPositionY && j == playerPositionX)
                    {
                        PrintPlayer(player);
                        continue;
                    }

                    Console.Write(map[i,j]);
                }

                Console.WriteLine();
            }
        }

        private static void PrintPlayer(char player)
        {
            Console.Write(player);
        }
    }
}
