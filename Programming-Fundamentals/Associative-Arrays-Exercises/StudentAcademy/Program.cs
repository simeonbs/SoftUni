using System;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //double asd = 9 * 1.0 / 2;
            //Console.WriteLine($"{asd:f10}");

            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<double>() { grade });
                }
                else
                {
                    dictionary[name].Add(grade);
                }
            }

            foreach (var item in dictionary)
            {
                double averageGrade = 1.0 * 
            }
        }
    }
}
