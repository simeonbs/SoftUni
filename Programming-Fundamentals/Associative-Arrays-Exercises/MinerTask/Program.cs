using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            bool isStop = true;

            while (isStop == true)
            {
                string resource = Console.ReadLine();
                
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (dictionary.ContainsKey(resource))
                {
                    dictionary[resource] += quantity;
                }
                else
                {
                    dictionary.Add(resource, quantity);
                }
                
                
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
