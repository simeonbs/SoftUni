using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] charArray = Console.ReadLine().Split();

            string text = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if (!dictionary.ContainsKey(currChar))
                {
                    dictionary.Add(currChar, 0);
                }

                dictionary[currChar]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
