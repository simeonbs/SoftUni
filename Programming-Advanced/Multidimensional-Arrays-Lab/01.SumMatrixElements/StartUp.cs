using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            

            int[,] matrix = new int[rows, cols];



            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            long sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}
