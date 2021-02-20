using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nm[0];
            int m = nm[1];

            int[,] matrix = new int[n, m];

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    matrix[r, c] = 0;
                }
            }

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                string[] cmdArg = input.Split();
                int row = int.Parse(cmdArg[0]);
                int col = int.Parse(cmdArg[1]);

                if (row >= n || row < 0 || col >= m || col < 0)
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine();
                    continue;
                }

                matrix[row, col]++;
                for (int i = 0; i < n; i++)
                {
                    if (i == row)
                    {
                        continue;
                    }
                    matrix[i, col]++;
                }

                for (int i = 0; i < m; i++)
                {
                    if (i == col)
                    {
                        continue;
                    }
                    matrix[row, i]++;
                }




                input = Console.ReadLine();


            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            

        }
    }
}
