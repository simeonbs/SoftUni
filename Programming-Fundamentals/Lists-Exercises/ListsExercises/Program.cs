using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                List<string> commandList = command.Split().ToList();
                string name = commandList[0];


                if (commandList.Count == 3)
                {
                    if (commandList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    if (commandList.Contains(name))
                    {
                        commandList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
