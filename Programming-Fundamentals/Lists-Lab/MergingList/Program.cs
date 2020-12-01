using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MergingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> nums2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(nums.Count, nums2.Count); i++)
            {
                result.Add(nums[i]);
                result.Add(nums2[i]);

            }

            for (int i = Math.Min(nums.Count, nums2.Count); i < Math.Max(nums.Count, nums2.Count); i++)
            {
                if (i >= nums.Count)
                {
                    result.Add(nums2[i]);
                }
                else
                {
                    result.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
