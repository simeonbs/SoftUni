using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();

            Predicate<string> actualLength = n => n.Length <= nameLength;

            Action<string[], Predicate<string>> print = ((arr, detirmenLength) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (actualLength(arr[i]))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }

            });

            print(names, actualLength);
        }
    }
}
