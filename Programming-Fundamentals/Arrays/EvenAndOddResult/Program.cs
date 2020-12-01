using System;
using System.Linq;

namespace EvenAndOddResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else if (numbers[i] % 2 == 1)
                {
                    sumOdd += numbers[i];

                }

            }
            int result = sumEven - sumOdd;
            Console.WriteLine(result);
        }
    }
}
