using System;

namespace midexamjanuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;
            int studentsPerHour = employee1 + employee2 + employee3;

            while (studentsCount > 0)
            {
                hours++; 
                if (hours % 4 == 0)
                {
                    
                    continue;
                }
                studentsCount -= studentsPerHour;
                
               

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
