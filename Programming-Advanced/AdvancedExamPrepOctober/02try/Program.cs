using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            int[,] garden = new int[n, m];
            Dictionary<int, int> plantedFlowers = new Dictionary<int, int>();

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                int[] dimensions = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = dimensions[0];
                int col = dimensions[1];
                if (row >= 0 && row < n && col >= 0 && col < m)
                {
                    garden[row, col] = 1;
                    plantedFlowers.Add(row, col);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }


                command = Console.ReadLine();
            }

            foreach (var flower in plantedFlowers)
            {
                int currentRow = flower.Key;
                int currentCol = flower.Value;
                for (int i = 0; i < n; i++)
                {
                    if (i == currentRow)
                    {
                        continue;
                    }
                    garden[i, currentCol]++;
                }
                for (int i = 0; i < m; i++)
                {
                    if (i == currentCol)
                    {
                        continue;
                    }
                    garden[currentRow, i]++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}