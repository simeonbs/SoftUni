using System;
using System.Data;
using System.Linq;

namespace Cupidon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int index = 0;
            string input = Console.ReadLine();

            while (input != "Love!")
            {
                string[] cmdArg = input.Split();
                int length = int.Parse(cmdArg[1]);
                index += length;

                if (index > array.Length - 1)
                {
                    index = 0;
                }

                if (array[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");

                    input = Console.ReadLine();
                    continue;
                }

                array[index] -= 2;


                


                input = Console.ReadLine();
            }
        }
    }
}
