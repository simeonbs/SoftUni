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

            Stack<int> stack = new Stack<int>();

            int n = nsx[0];
            int s = nsx[1];
            int x = nsx[2];

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {

                Console.WriteLine("true");
                return;
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }



        }
    }
}
