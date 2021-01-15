using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(numbers);
            int rackSum = 0;
            int sum = 0;

            while (stack.Count >= 1)
            {
                
                while (capacity - sum > 0)
                {
                    if (stack.Count <= 0)
                    {
                        break;
                    }
                    if (stack.Count > 0)
                    {
                        sum += stack.Pop();
                    }
                    
                }
                if (capacity - sum <= 0)
                {
                    rackSum++;
                    sum = 0;
                }
                else if (sum > capacity)
                {
                    rackSum++;
                }
            }

            Console.WriteLine(rackSum);
        }
    }
}
