using System;
using System.Linq;
namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            int playerRow = 0;
            int playerCol = 0;

            for (int r = 0; r < n; r++)
            {
                string rowData = Console.ReadLine();
                char[] rowDataChar = rowData.ToCharArray();
                for (int c = 0; c < n; c++)
                {
                    if (rowDataChar[c] == 'S')
                    {
                        playerCol = c;
                        playerRow = r;

                    }

                    if (true)
                    {

                    }

                    if (true)
                    {

                    }
                    matrix[r, c] = rowDataChar[c].ToString();
                }
            }

            ;
        }
    }
}
