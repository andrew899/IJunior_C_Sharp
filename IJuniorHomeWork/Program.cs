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
                InputFromUser(ref playerNewPositionX, ref playerNewPositionY, ref isExit, playerInput);

                if((playerPositionX != playerNewPositionX || playerPositionY != playerNewPositionY) && map[playerNewPositionY, playerNewPositionX] != wallSymbol)
                {
                    ChagePlayerPosition(out playerPositionX, out playerPositionY, playerNewPositionX, playerNewPositionY);
                }
                else
                {
                    ResetPlayerNewPosition(out playerNewPositionX, out playerNewPositionY, playerPositionX, playerPositionY);
                }
            }
        }

        private static void ResetPlayerNewPosition(out int playerNewPositionX, out int playerNewPositionY, int playerPositionX, int playerPositionY)
        {
            playerNewPositionX = playerPositionX;
            playerNewPositionY = playerPositionY;
        }

        private static void InputFromUser(ref int playerNewPositionX, ref int playerNewPositionY, ref bool isExit, ConsoleKey playerInput)
        {
            switch (playerInput)
            {
                case ConsoleKey.W:
                        playerNewPositionY--;
                        break;

                case ConsoleKey.S:
                        playerNewPositionY++;
                        break;

                case ConsoleKey.A:
                        playerNewPositionX--;
                        break;

                case ConsoleKey.D:
                        playerNewPositionX++;
                        break;

                case ConsoleKey.Escape:
                        isExit = true;
                        break;

                default:
                        Console.WriteLine("Wrong input, W - Up, S - Down, A - Left, D - Right, ESC - Exit. = Wall, * Finish");
                        break;
            }
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
