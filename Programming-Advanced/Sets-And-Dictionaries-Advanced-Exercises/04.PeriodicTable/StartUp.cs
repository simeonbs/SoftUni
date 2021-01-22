using System;
using System.Collections.Generic;

namespace _04.PeriodicTable
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 1)
                {
                    sortedSet.Add(input[0]);
                }
                else
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        sortedSet.Add(input[j]);
                    }
                }
                
            }

            foreach (var item in sortedSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}
