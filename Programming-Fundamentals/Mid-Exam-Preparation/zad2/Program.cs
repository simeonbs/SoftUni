using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            //23 -2 321 87 42 90 -123
            List<long> list = Console.ReadLine().Split(" ").Select(long.Parse).ToList();

            string input = Console.ReadLine();

            
            while (input != "end")
            {
                string[] command = input.Split();
                string cmdArg = command[0];
                // int indexOfFirst = list.IndexOf(list[firstIndex]);
                // int indexOfSecond = list.IndexOf(list[secondIndex]);
                if (cmdArg == "swap")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    int indexOfFirst = list.IndexOf(list[firstIndex]);
                    int indexOfSecond = list.IndexOf(list[secondIndex]);
                    long current = list[firstIndex];
                    if (firstIndex >= 0 && firstIndex < list.Count)
                    {
                        list[indexOfFirst] = list[indexOfSecond]; // 1 = 2
                        list[indexOfSecond] = current; // 2 = 1
                    }
                    else
                    {
                        break;
                    }
                     

                }
                if (cmdArg == "multiply")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    if (firstIndex >= 0 && firstIndex < list.Count)
                    {
                       list[firstIndex] = list[firstIndex] * list[secondIndex];
                    }
                    else
                    {
                        break;
                    }
                }
                if (cmdArg == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = list[i] - 1;
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
