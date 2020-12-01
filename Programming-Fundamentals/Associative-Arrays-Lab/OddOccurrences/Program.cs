using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> countsOfOccurrences = new Dictionary<string, int>();

            foreach (string item in words)
            {
                string wordInLower = item.ToLower();

                if (countsOfOccurrences.ContainsKey(wordInLower))
                {
                    countsOfOccurrences[wordInLower]++;
                }
                else
                {
                    countsOfOccurrences.Add(wordInLower, 1);
                }
            }

            foreach (var item in countsOfOccurrences)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
