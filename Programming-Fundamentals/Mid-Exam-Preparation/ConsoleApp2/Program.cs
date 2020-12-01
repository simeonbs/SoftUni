using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            string input = Console.ReadLine();

            bool isWon = false;

            int moves = 0;


            // 0 1 2 3 4
            // 1 2 3 4 5

            while (input != "end")
            {
                string[] cmdArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int firstIndex = int.Parse(cmdArg[0]);
                int secondIndex = int.Parse(cmdArg[1]);

                if (list.Count == 0)
                {
                    isWon = true;
                    break;
                }

                else if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= list.Count || secondIndex < 0 || secondIndex >= list.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    moves++;
                    int middle = list.Count / 2;
                    //Nachin 1
                    string[] addOn = { $"-{moves}a", $"-{moves}a" };
                    list.InsertRange(middle, addOn);

                    //Nachin 2

                    
                    //if (middle != 0)
                    //{
                    //    list.Insert(middle, numberToInsert);
                    //    list.Insert(middle + 1, numberToInsert);
                    //}
                    
                    input = Console.ReadLine();
                    continue;
                }

                else if (list[firstIndex] == list[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[firstIndex]}!");

                    //Nachin 1
                    if (firstIndex > secondIndex)
                    {
                        list.RemoveAt(firstIndex);
                        list.RemoveAt(secondIndex);
                    }
                    else if (secondIndex > firstIndex)
                    {
                        list.RemoveAt(secondIndex);
                        list.RemoveAt(firstIndex);
                    }

                    //Nachin 2

                    //string item = list[firstIndex];
                    //list.RemoveAll(x => x == item);

                    //list.RemoveAt(firstIndex);
                    //list.RemoveAt(secondIndex);
                    moves++;
                    
                    
                }
                else if (list[firstIndex] != list[secondIndex])
                {
                    moves++;
                    Console.WriteLine("Try again!");
                }

                
               

                input = Console.ReadLine();
            }

            if (isWon == true)
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }

            if (list.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }

            
        }
    }
}
