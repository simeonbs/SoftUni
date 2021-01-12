using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();

            Stack<int> stack = new Stack<int>();
            foreach (var item in integers)
            {
                stack.Push(item);
            }


            while (command != "end")
            {
                string[] cmdArg = command.Split();
                if (cmdArg[0] == "add")
                {
                    stack.Push(int.Parse(cmdArg[1]));
                    stack.Push(int.Parse(cmdArg[2]));
                }
                else if (cmdArg[0] == "remove")
                {
                    int count = int.Parse(cmdArg[1]);
                    if (stack.Count > count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
