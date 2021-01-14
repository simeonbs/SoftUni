using System;
using System.Collections.Generic;

namespace StacksAndQueuesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
