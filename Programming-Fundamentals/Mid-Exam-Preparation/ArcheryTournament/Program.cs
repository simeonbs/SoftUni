using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 10 10 10 10
            //  0  1  2  3  4
            List<int> list = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "Game over")
            {
                string[] cmdArg = input.Split("@");
                string command = cmdArg[0];

                if (command == "Shoot Left")
                {
                    int index = int.Parse(cmdArg[1]);
                    int length = int.Parse(cmdArg[2]);
                    for (int i = index; i <= length + 1; i++)
                    {
                        if (index < 0 || index > list.Count)
                        {
                            index = 0;
                        }
                        if (i == length + 1)
                        {
                            list[length + 1] -= 5;
                        }
                    }
                }



                input = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
