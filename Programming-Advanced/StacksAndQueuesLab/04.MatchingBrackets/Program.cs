using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            string text = String.Join(" ", array);
            Console.WriteLine(text);

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains("("))
                {
                    stack.Push(i);
                }

                else if (array[i].Contains(")"))
                {
                    int startIndex = stack.Pop();
                    Console.WriteLine(text.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
