using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = nums
                .Where(n => n >= 0)
                .Reverse()
                .ToList();

            int count = result.Count;

            if (count == 0)
            {
                Console.WriteLine("empty");
            }

            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
