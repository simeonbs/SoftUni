using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            static void Triangle(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Triangle(1, i);
            }

            for (int j = n - 1; j >= 1; j--)
            {
                Triangle(1, j);
            }

        }
    }
}
