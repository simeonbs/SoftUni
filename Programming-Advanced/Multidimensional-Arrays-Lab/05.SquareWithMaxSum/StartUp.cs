using System;
using System.Linq;

namespace _05.SquareWithMaxSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int sum = 0;
            int biggestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                { 
                    int currSquare = matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row + 1, col] 
                        + matrix[row + 1, col + 1];

                    if (currSquare > biggestSum)
                    {
                        biggestSum = currSquare;
                        bestRow = row;
                        bestCol = col;

                    }


                }
            }

            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
            Console.WriteLine(biggestSum);
        }
    }
}
