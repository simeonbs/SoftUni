using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                    command = Console.ReadLine();
                    continue;
                }
                queue.Enqueue(command);


                command = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
