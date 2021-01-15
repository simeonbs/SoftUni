using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split().ToArray();

                string type = cmdArg[0];


                if (type == "1")
                {
                    string number = cmdArg[1];
                    stack.Push(int.Parse(number));
                }
                else if (type == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else if (type == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (type == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
