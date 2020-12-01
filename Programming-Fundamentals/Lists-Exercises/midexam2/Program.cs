using System;
using System.Collections.Generic;
using System.Linq;

namespace midexam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split("@").ToArray();

            while (command[0] != "Game Over")
            {
                if (command[0] == "Shoot Left")
                {
                     int   
                }

                else if (command[0] == "Shoot Right")
                {

                }

                else if (command[0] == "Reverse")
                {

                }

                command = Console.ReadLine().Split("@").ToArray();
            }
        }
    }
}
