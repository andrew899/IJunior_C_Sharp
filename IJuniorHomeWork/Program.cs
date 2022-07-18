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
            int playerNewPositionX = playerPositionX;
            int playerNewPositionY = playerPositionY;
            bool isExit = false;
            ConsoleKey playerInput;

            Console.WriteLine("W - Up, S - Down, A - Left, D - Right. = Wall, * Finish");

            while (isExit == false)
            {
                if (IsPlayerWin(map, playerPositionX, playerPositionY, finishSymbol))
                {
                    Console.WriteLine("\nCongratulations. You WIN!!!");
                    isExit = true;
                    continue;
                }

                PrintMap(map, playerPositionX, playerPositionY, player);
                playerInput = Console.ReadKey().Key;

                if(TryGetNewPosition(ref playerNewPositionX, ref playerNewPositionY, playerInput))
                {
                    if((playerPositionX != playerNewPositionX || playerPositionY != playerNewPositionY) && map[playerNewPositionY, playerNewPositionX] != wallSymbol)
                    {
                        ChagePlayerPosition(out playerPositionX, out playerPositionY, playerNewPositionX, playerNewPositionY);
                    }
                    else
                    {
                        ChagePlayerPosition(out playerNewPositionX, out playerNewPositionY, playerPositionX, playerPositionY);
                    }
                }

                else if (playerInput == ConsoleKey.Escape)
                {
                    isExit = true;
                }

                else
                {
                    Console.WriteLine("Wrong input, W - Up, S - Down, A - Left, D - Right, ESC - Exit. = Wall, * Finish");
                }
            }
        }

        private static bool TryGetNewPosition(ref int playerNewPositionX, ref int playerNewPositionY, ConsoleKey playerInput)
        {
            bool result = false;

            switch (playerInput)
            {
                case ConsoleKey.W:
                    playerNewPositionY--;
                    result = true;
                    break;

                case ConsoleKey.S:
                    playerNewPositionY++;
                    result = true;
                    break;

                case ConsoleKey.A:
                    playerNewPositionX--;
                    result = true;
                    break;

                case ConsoleKey.D:
                    playerNewPositionX++;
                    result = true;
                    break;
            }

            return result;
        }

        private static void ChagePlayerPosition(out int playerPositionX, out int playerPositionY, int playerNewPositionX, int playerNewPositionY)
        {
            playerPositionX = playerNewPositionX;
            playerPositionY = playerNewPositionY;
        }

        private static bool IsPlayerWin(char[,] map, int playerPositionX, int playerPositionY, char finishSymbol)
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
