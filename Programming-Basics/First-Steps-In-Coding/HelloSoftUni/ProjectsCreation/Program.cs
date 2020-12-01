using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int number1 = number * 3;
            Console.WriteLine($"The architect {name} will need {number1} hours to complete {number} project/s.");


        }
    }
}
