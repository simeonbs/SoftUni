using System;
using System.Linq;
namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;
            int food = 0;

            for (int r = 0; r < n; r++)
            {
                string rowData = Console.ReadLine();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = rowData[c];
                    if (rowData[c] == 'S')
                    {
                        playerCol = c;
                        playerRow = r;

                    }

                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = playerRow - 1;
                    if (playerRow >= 0)
                    {
                        Move(n, matrix, ref playerRow, ref playerCol, ref food);
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {food}");
                        break;
                    }
                }

                else if (command == "down")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerRow = playerRow + 1;
                    if (playerRow < n)
                    {
                        Move(n, matrix, ref playerRow, ref playerCol, ref food);

                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {food}");
                        break;
                    }
                }

                else if (command == "left")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol -= 1;
                    if (playerCol >= 0)
                    {
                        Move(n, matrix, ref playerRow, ref playerCol, ref food);

                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {food}");
                        break;
                    }
                }

                else if (command == "right")
                {
                    matrix[playerRow, playerCol] = '-';
                    playerCol += 1;
                    if (playerCol < n)
                    {
                        Move(n, matrix, ref playerRow, ref playerCol, ref food);

                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {food}");
                        break;
                    }
                }

                if (food >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    Console.WriteLine($"Money: {food}");
                    matrix[playerRow, playerCol] = 'S';
                    break;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }

            

        }

        private static void Move(int n, char[,] matrix, ref int playerRow, ref int playerCol, ref int food)
        {
            if (char.IsDigit(matrix[playerRow, playerCol]))
            {
                food += int.Parse(matrix[playerRow, playerCol].ToString());
            }

            else if (matrix[playerRow, playerCol] == 'O')
            {
                matrix[playerRow, playerCol] = '-';
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        if (matrix[r, c] == 'O')
                        {
                            playerCol = c;
                            playerRow = r;
                        }
                    }
                }
            }
        }
    }
}
