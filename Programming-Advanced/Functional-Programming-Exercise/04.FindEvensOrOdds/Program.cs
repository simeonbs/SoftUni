using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            string evenOrOdd = Console.ReadLine();

            int start = array[0];
            int end = array[1];

            List<int> nums = new List<int>();

            for (int i = start; i <= end; i++)
            {
                nums.Add(i);
            }

            Predicate<int> predicate = x => true;

            if (evenOrOdd == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else if (evenOrOdd == "odd")
            {
                predicate = x => x % 2 != 0;
            }

            Action<List<int>> printNums =
                x => Console.WriteLine(string.Join(" ", x.Where(x => predicate(x))));

            printNums(nums);
        }
    }
}
