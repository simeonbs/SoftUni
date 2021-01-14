using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            var even = new List<int>();

            foreach (var item in intarray)
            {
                queue.Enqueue(item);
            }

            int current = 0;
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                current = queue.Dequeue();

                if (current % 2 == 0)
                {
                    even.Add(current);
                }
            }

            Console.WriteLine(String.Join(", ", even));

        }
    }
}
