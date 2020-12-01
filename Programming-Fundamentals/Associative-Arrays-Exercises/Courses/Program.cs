using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            int count = 1;

            while (input != "end")
            {

                string[] cmdArg = input.Split(" : ");
                string course = cmdArg[0];

                if (!dictionary.ContainsKey(course))
                {
                    dictionary.Add(course, new List<string>(5) { cmdArg[1] });
                    

                }
                else
                {
                    dictionary[course].Add(cmdArg[1]);
                    count++;
                }


                input = Console.ReadLine();
            }

            
            foreach (var item in dictionary.OrderByDescending(x => x.Value.Count()))
            {
                string names = item.Value[0].ToString();

                List<string> list = names.Split(", ").ToList();

                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> orderedList = list.OrderBy(x => x).ToList();
                foreach (var asd in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {asd}");
                }
            }


        }
    }
}
