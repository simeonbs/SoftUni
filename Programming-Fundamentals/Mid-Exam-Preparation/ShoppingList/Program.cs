using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                string item = cmdArg[1];

                switch (command)
                {
                    case "Urgent":

                        if (!products.Contains(item))
                        {
                            products.Insert(0, item);
                        }
                        else
                        {
                            break;
                        }
                        break;

                    case "Unnecessary":
                        if (products.Contains(item))
                        {
                            products.Remove(item);
                        }
                        else
                        {
                            break;
                        }
                        break;

                    case "Correct":
                        string oldName = cmdArg[1];
                        string newName = cmdArg[2];
                        if (products.Contains(oldName))
                        {
                            int indexOfOld = products.IndexOf(oldName);
                            products[indexOfOld] = newName;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "Rearrange":
                        if (products.Contains(item))
                        {
                            int index = products.IndexOf(item);
                            products.Add(item);
                            products.RemoveAt(index);
                        }
                        else
                        {
                            break;
                        }
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
