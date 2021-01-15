using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());

            int[] clients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(clients);

            Console.WriteLine(queue.Max());

            int count = queue.Count();

            bool isComplete = true;

            for (int i = 0; i < count; i++)
            {
                int current = clients[i];
                if (foodAmount >= current)
                {
                    foodAmount -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
                    isComplete = false;
                    break;
                }
            }

            if (isComplete)
            {
                Console.WriteLine($"Orders complete");
                
            }
            
        }
    }
}
