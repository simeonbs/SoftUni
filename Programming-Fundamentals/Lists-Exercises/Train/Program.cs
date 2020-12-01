using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int numberOfNewWagon = int.Parse(command[1]);
                    wagons.Add(numberOfNewWagon);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int numberToAdd = int.Parse(command[0]);
                        if (numberToAdd + wagons[i] <= maxCapacity)
                        {
                            wagons[i] += numberToAdd;
                            break;
                        }
                    }
                }
                
             command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }


    }
}

