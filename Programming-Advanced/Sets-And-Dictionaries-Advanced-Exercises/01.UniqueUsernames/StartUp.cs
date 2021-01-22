using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> hashset = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                hashset.Add(Console.ReadLine());
            }

            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
