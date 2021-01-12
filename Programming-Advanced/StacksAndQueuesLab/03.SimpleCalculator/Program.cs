using System;
using System.Collections.Generic;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item.ToString());
            }

            

            Stack<string> reversed = new Stack<string>();

            while (stack.Count != 0)
            {
                reversed.Push(stack.Pop());
            }


            while (reversed.Count > 1)
            {
                int leftNumber = int.Parse(reversed.Pop());
                string sign = reversed.Pop();
                int rightNumber = int.Parse(reversed.Pop());

                if (sign == "+")
                {
                    reversed.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    reversed.Push((leftNumber - rightNumber).ToString());
                }
            }

            Console.WriteLine(reversed.Pop());
        }
    }
}
