using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> greater = new List<int>();
            int average = list.Sum() / list.Count;

            

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    greater.Add(list[i]);
                }
            }

            if (greater.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            List<int> newList = greater.OrderByDescending(x => x).ToList();
            if (newList.Count > 5)
            {
                newList.RemoveRange(5, newList.Count - 5);
            }
            
            // 1 2 3 4 5 . 6 7 8
            
            
            Console.WriteLine(string.Join(" ", newList));
            
        }
    }
}
