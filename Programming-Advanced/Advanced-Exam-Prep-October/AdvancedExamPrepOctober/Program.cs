using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExamPrepOctober
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int taskToBeKilled = int.Parse(Console.ReadLine());

            while (true)
            {
                int currTask = tasks.Peek();
                int currThread = threads.Peek();

                if (currTask == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {currThread} killed task {taskToBeKilled}");
                    Console.WriteLine(string.Join(" ", threads));
                    break;
                }
                if (currThread >= currTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }

            }
        }
    }
}