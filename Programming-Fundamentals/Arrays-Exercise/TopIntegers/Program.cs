using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isBigger = true;

            for (int i = 0; i < array.Length; i++)
            {
                int currentInt = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }

                }
                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }
                isBigger = true;
            }
        }
    }
}
