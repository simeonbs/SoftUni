using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Condense
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
            int[] condensed = new int[array.Length];

            //2 10 3
            //0 1  2

            for (int i = 0; i < array.Length - 1; i++)
            {
                
                condensed[i] = array[i + 1] + array[i];
                
            }
            int sum = condensed.Sum();
            Console.WriteLine(sum);
        }
    }
}
