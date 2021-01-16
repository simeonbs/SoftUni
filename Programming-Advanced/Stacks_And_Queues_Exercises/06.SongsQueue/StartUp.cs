using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(songs);


            

            while (queue.Any())
            {
                string input = Console.ReadLine();
                

                if (input == "Play")
                {
                    queue.Dequeue();
                }

                else if (input.StartsWith("Add"))
                {
                    string songFullName = input.Substring(4);
                    if (!queue.Contains(songFullName))
                    {
                        queue.Enqueue(songFullName);
                    }
                    else
                    {
                        Console.WriteLine($"{songFullName} is already contained!");
                    }
                    
                }

                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
