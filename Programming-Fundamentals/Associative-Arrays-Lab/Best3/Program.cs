using System;
using System.Linq;

namespace Best3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] sortedNumbers = numbers.OrderByDescending(n => n).ToArray();

            int count = 0;
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                Console.Write(sortedNumbers[i] + " ");
                count++;
                if (count == 3)
                {
                    return;
                }
            }
        }
    }
}
