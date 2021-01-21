using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col].ToString();
                }
            }

            string symbolToFind = Console.ReadLine();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    string currChar = matrix[row, col];
                    if (currChar == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}
