using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();

            foreach (var item in array)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
