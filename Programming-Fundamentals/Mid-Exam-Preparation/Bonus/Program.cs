using System;
using System.ComponentModel.DataAnnotations;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = int.Parse(Console.ReadLine());

            double lecturesCount = int.Parse(Console.ReadLine());

            double additionalBonus = int.Parse(Console.ReadLine());
            double bestBonus = 0;
            double bestStudent = 0;
            


            for (int i = 0; i < studentsCount; i++)
            {
                double attendances = int.Parse(Console.ReadLine());
                double totalBonus = Math.Round((attendances / lecturesCount) * (5 + additionalBonus));
                double currentStudent = attendances;
                if (totalBonus > bestBonus)
                {
                    bestBonus = totalBonus;
                    bestStudent = currentStudent;
                }
            }
            Console.WriteLine($"Max Bonus: {bestBonus}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
