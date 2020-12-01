using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>(10);
            int numberOfCommands = int.Parse(Console.ReadLine());
            int count = 0;
            List<string> command = Console.ReadLine().Split(" ").ToList();

            
            while (count != numberOfCommands)
            {
                



                count++;
                command = Console.ReadLine().Split(" ").ToList();
            }
        }
    }
}
