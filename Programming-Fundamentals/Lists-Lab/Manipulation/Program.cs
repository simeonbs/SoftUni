using System;
using System.Collections.Generic;
using System.Linq;

namespace Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
