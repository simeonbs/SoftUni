using System;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (var word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
