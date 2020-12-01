using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        int element = int.Parse(command[1]);
                        myList.RemoveAll(x => x == element);
                        break;
                    case "Insert":
                        int element2 = int.Parse(command[1]);
                        int position = int.Parse(command[2]);
                        myList.Insert(position, element2);
                        break;
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }

            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
