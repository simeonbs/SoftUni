using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            HashSet<int> firstGroup = new HashSet<int>();
            HashSet<int> secondGroup = new HashSet<int>();

            for (int i = 0; i < sets[0] + sets[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < sets[0])
                {
                    firstGroup.Add(number);
                }
                else
                {
                    secondGroup.Add(number);
                }
            }

            var intersection = firstGroup.Intersect(secondGroup);

            Console.WriteLine(string.Join(" ", intersection));
        }
    }
}
