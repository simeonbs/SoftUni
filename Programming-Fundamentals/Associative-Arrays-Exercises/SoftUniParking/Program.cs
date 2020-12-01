using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split();

                if (arr[0] == "register")
                {
                    if (dictionary.ContainsKey(arr[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {arr[2]}");
                    }
                    else
                    {
                        dictionary.Add(arr[1], arr[2]);
                        Console.WriteLine($"{arr[1]} registered {arr[2]} successfully");
                    }
                }
                else if (arr[0] == "unregister")
                {
                    if (!dictionary.ContainsKey(arr[1]))
                    {
                        Console.WriteLine($"ERROR: user {arr[1]} not found");
                    }
                    else
                    {
                        dictionary.Remove(arr[1]);
                        Console.WriteLine($"{arr[1]} unregistered successfully");
                    }
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
