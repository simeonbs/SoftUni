using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] cmdArg = input.Split(" - ");
                string command = cmdArg[0];

                if (command == "Collect")
                {
                    string item = cmdArg[1];
                    if (items.Contains(item))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        items.Add(item);
                    }
                }

                else if (command == "Drop")
                {
                    string item = cmdArg[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (command == "Combine Items")
                {
                    string currComand = cmdArg[1];
                    string[] combinedCommand = currComand.Split(":");
                    string oldItem = combinedCommand[0];
                    string newItem = combinedCommand[1];

                    if (items.Contains(oldItem))
                    {
                        int oldIndex = items.IndexOf(oldItem);
                        if (oldIndex >= 0)
                        {
                            items.Insert(oldIndex + 1, newItem);

                        }


                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                else if (command == "Renew")
                {
                    string item = cmdArg[1];
                    int index = items.IndexOf(item);
                    if (index >= 0)
                    {
                        items.Add(item);
                        items.RemoveAt(index);
                    }
                    
                    //1 2 3 4
                    //1 2 3 4 2
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
