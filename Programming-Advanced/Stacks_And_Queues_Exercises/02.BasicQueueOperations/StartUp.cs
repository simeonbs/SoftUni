using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_And_Queues_Exercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {

                Console.WriteLine("true");
                return;
            }
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }



        }
    }
}
