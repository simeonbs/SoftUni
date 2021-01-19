using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_And_Dictionaries_Advanced
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!count.ContainsKey(numbers[i]))
                {
                    count.Add(numbers[i], 0);
                }

                count[numbers[i]]++;
            }

            foreach (var time in count)
            {
                Console.WriteLine($"{time.Key} - {time.Value} times");
            }
        }
    }
}
