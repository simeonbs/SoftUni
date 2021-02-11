using System;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;
            int eatenFood = 0;
            for (int r = 0; r < n; r++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = rowData[c];
                    if (rowData[c] == 'S')
                    {
                        playerRow = r;
                        playerCol = c;
                    }
                }
            }

            string command = Console.ReadLine();
            while (true)
            {
                if (eatenFood == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
                if (command == "up")
                {
                    matrix[playerRow, playerCol] = '.';
                    playerRow--;
                    if (playerRow < 0)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '.';
                            for (int r = 0; r < n; r++)
                            {
                                for (int c = 0; c < n; c++)
                                {
                                    if (matrix[r, c] == 'B')
                                    {
                                        playerRow = r;
                                        playerCol = c;
                                        matrix[playerRow, playerCol] = 'S';
                                    }
                                }
                            }

                        }
                        if (matrix[playerRow, playerCol] == '*')
                        {
                            matrix[playerRow, playerCol] = 'S';
                            eatenFood++;
                        }
                    }
                }
                if (command == "down")
                {
                    matrix[playerRow, playerCol] = '.';
                    playerRow++;
                    if (playerRow >= n)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '.';
                            for (int r = 0; r < n; r++)
                            {
                                for (int c = 0; c < n; c++)
                                {
                                    if (matrix[r, c] == 'B')
                                    {
                                        playerRow = r;
                                        playerCol = c;
                                        matrix[playerRow, playerCol] = 'S';
                                    }
                                }
                            }

                        }
                        if (matrix[playerRow, playerCol] == '*')
                        {
                            matrix[playerRow, playerCol] = 'S';
                            eatenFood++;
                        }
                    }
                }
                if (command == "left")
                {
                    matrix[playerRow, playerCol] = '.';
                    playerCol--;
                    if (playerCol < 0)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '.';
                            for (int r = 0; r < n; r++)
                            {
                                for (int c = 0; c < n; c++)
                                {
                                    if (matrix[r, c] == 'B')
                                    {
                                        playerRow = r;
                                        playerCol = c;
                                        matrix[playerRow, playerCol] = 'S';
                                    }
                                }
                            }

                        }
                        if (matrix[playerRow, playerCol] == '*')
                        {
                            matrix[playerRow, playerCol] = 'S';
                            eatenFood++;
                        }
                    }
                }
                if (command == "right")
                {
                    matrix[playerRow, playerCol] = '.';
                    playerCol++;
                    if (playerCol >= n)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            matrix[playerRow, playerCol] = '.';
                            for (int r = 0; r < n; r++)
                            {
                                for (int c = 0; c < n; c++)
                                {
                                    if (matrix[r, c] == 'B')
                                    {
                                        playerRow = r;
                                        playerCol = c;
                                        matrix[playerRow, playerCol] = 'S';
                                    }
                                }
                            }

                        }
                        if (matrix[playerRow, playerCol] == '*')
                        {
                            matrix[playerRow, playerCol] = 'S';
                            eatenFood++;
                        }
                    }
                }

                // END
                command = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {eatenFood}");
            PrintMatrix(n, matrix);

        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
