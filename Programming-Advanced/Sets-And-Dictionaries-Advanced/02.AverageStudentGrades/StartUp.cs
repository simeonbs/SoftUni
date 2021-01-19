using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine().Split();
                var name = student[0];
                var grade = decimal.Parse(student[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());  
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var item in studentsGrades)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
