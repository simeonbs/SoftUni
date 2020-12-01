using System;

namespace SumOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(2 * i - 1);
                    sum += 2 * i - 1;
                }
                
            }
         }
    }
}
