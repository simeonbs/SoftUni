using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;

            for (int r = 0; r < n; r++)
            {
                string rowData = Console.ReadLine();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = rowData[c];
                    if (rowData[c] == 'B')
                    {
                        playerRow = r;
                        playerCol = c;
                    }
                }
            }

            string input = Console.ReadLine();

            int specialFlowers = 0;
            while (input != "End")
            {
                if (input == "up")
                {
                    matrix[playerRow, playerCol] = '.';
                    if (playerRow - 1 >= 0)
                    {
                        if (matrix[playerRow - 1, playerCol] == 'f')
                        {
                            specialFlowers++;
                            matrix[playerRow - 1, playerCol] = 'B';
                            playerRow = playerRow - 1;
                        }
                        else if (matrix[playerRow - 1, playerCol] == 'O')
                        {
                            if (playerRow - 2 >= 0)
                            {
                                matrix[playerRow - 2, playerCol] = 'B';
                                if (matrix[playerRow - 1, playerCol] == 'f')
                                {
                                    specialFlowers++;
                                    matrix[playerRow - 1, playerCol] = '.';
                                }
                                else
                                {
                                    matrix[playerRow - 1, playerCol] = '.';
                                }
                                
                                playerRow = playerRow - 2;
                            }
                            else
                            {
                                matrix[playerRow - 1, playerCol] = '.';
                                playerRow = playerRow - 1;
                                Console.WriteLine("The bee got lost!");
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow - 1, playerCol] = 'B';
                            playerRow = playerRow - 1;
                        }

                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                if (input == "down")
                {
                    matrix[playerRow, playerCol] = '.';
                    if (playerRow + 1 < n)
                    {
                        if (matrix[playerRow + 1, playerCol] == 'f')
                        {
                            specialFlowers++;
                            matrix[playerRow + 1, playerCol] = 'B';
                            playerRow = playerRow + 1;
                        }
                        else if (matrix[playerRow + 1, playerCol] == 'O')
                        {
                            if (playerRow + 2 < n)
                            {
                                matrix[playerRow + 2, playerCol] = 'B';
                                if (matrix[playerRow + 1, playerCol] == 'f')
                                {
                                    specialFlowers++;
                                    matrix[playerRow + 1, playerCol] = '.';
                                }
                                else
                                {
                                    matrix[playerRow + 1, playerCol] = '.';
                                }
                                matrix[playerRow + 1, playerCol] = '.';
                                playerRow = playerRow + 2;
                            }
                            else
                            {
                                matrix[playerRow + 1, playerCol] = '.';
                                playerRow = playerRow + 1;
                                Console.WriteLine("The bee got lost!");
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow + 1, playerCol] = 'B';
                            playerRow = playerRow + 1;
                        }

                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                }

                if (input == "left")
                {
                    matrix[playerRow, playerCol] = '.';
                    if (playerCol - 1 >= 0)
                    {
                        if (matrix[playerRow, playerCol - 1] == 'f')
                        {
                            specialFlowers++;
                            matrix[playerRow, playerCol - 1] = 'B';
                            playerCol = playerCol - 1;
                        }
                        else if (matrix[playerRow, playerCol - 1] == 'O')
                        {
                            if (playerCol - 2 >= 0)
                            {
                                matrix[playerRow, playerCol - 2] = 'B';
                                if (matrix[playerRow, playerCol - 1] == 'f')
                                {
                                    specialFlowers++;
                                    matrix[playerRow, playerCol - 1] = '.';
                                }
                                else
                                {
                                    matrix[playerRow, playerCol - 1] = '.';
                                }
                                
                                playerCol = playerCol - 2;
                            }
                            else
                            {
                                matrix[playerRow, playerCol - 2] = '.';
                                playerCol = playerCol - 1;
                                Console.WriteLine("The bee got lost!");
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow, playerCol - 1] = 'B';
                            playerCol = playerCol - 1;
                        }

                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                if (input == "right")
                {
                    matrix[playerRow, playerCol] = '.';
                    if (playerCol + 1 < n)
                    {
                        if (matrix[playerRow, playerCol + 1] == 'f')
                        {
                            specialFlowers++;
                            matrix[playerRow, playerCol + 1] = 'B';
                            playerCol = playerCol + 1;
                        }
                        else if (matrix[playerRow, playerCol + 1] == 'O')
                        {
                            if (playerCol + 2 < n)
                            {
                                matrix[playerRow, playerCol + 2] = 'B';
                                if (matrix[playerRow, playerCol + 1] == 'f')
                                {
                                    specialFlowers++;
                                    matrix[playerRow, playerCol + 1] = '.';
                                }
                                else
                                {
                                    matrix[playerRow, playerCol + 1] = '.';
                                }
                                playerCol = playerCol + 2;
                            }
                            else
                            {
                                matrix[playerRow, playerCol + 1] = '.';
                                playerCol = playerCol + 1;
                                Console.WriteLine("The bee got lost!");
                                break;
                            }
                        }
                        else
                        {
                            matrix[playerRow, playerCol + 1] = 'B';
                            playerCol = playerCol + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            if (specialFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - specialFlowers} flowers more");
            }
            if (specialFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {specialFlowers} flowers!");
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }

            //end
        }
    }
}
            
