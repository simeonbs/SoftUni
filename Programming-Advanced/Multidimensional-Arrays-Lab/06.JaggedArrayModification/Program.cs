using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = rowData;
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                int row = int.Parse(cmdArg[1]);
                int col = int.Parse(cmdArg[2]);
                int value = int.Parse(cmdArg[3]);



                if (command == "Add")
                {
                    if (row >= 0 && row < n && col >= 0 && col < n)
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                
                else if (command == "Subtract")
                {
                    if (row >= 0 && row <= n && col >= 0 && col <= n)
                    {
                        jaggedArray[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    
                }


                input = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
