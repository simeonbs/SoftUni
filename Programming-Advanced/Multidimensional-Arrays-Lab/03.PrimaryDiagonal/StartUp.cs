using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                sum += matrix[row, row];
            }


            Console.WriteLine(sum);


        }
    }
}
