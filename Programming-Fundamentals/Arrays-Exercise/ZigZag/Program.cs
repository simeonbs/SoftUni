using System;
using System.Linq;

namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split(" ").ToArray();

                string indZero = currentArray[0];
                string indOne = currentArray[1];

                if (i % 2 == 0)
                {
                    arr1[i] = indZero;
                    arr2[i] = indOne;
                }
                else if (i % 2 == 1)
                {
                    arr1[i] = indOne;
                    arr2[i] = indZero;
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}
