using System;
using System.Linq;

namespace MaxSequance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();

            int bestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currElement = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currElement == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }

                }

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                }


            }
            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
