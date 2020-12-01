using System;
using System.Linq;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split("").Select(double.Parse).ToArray();
            //string[] array = Console.ReadLine().Split("");
            //string number = int.Parse(Console.ReadLine());
            //int[] number = double.Parse(Console.ReadLine());
            GetSumOfEvenDigits(array);
        }

        static void GetSumOfEvenDigits(double[] array)
        {
            double evenSum = 0;
            double oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenSum += array[i];
                }
                else if (array[i] % 2 == 1)
                {
                    oddSum += array[i];
                }
            }
            Console.WriteLine($"{evenSum} , {oddSum}");
        }
    }
}
