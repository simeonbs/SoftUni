using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numbersOfRotation = int.Parse(Console.ReadLine());
            

            //51 47 32 61 21
            //47 32 61 21 51

            for (int i = 0; i < numbersOfRotation; i++)
            {
                int first = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    int currentElement = array[j];
                    array[j - 1] = currentElement;
                }
                array[array.Length - 1] = first;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
