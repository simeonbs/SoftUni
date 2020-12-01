using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 2 == 0) 
            {
                Console.WriteLine($"Even");
            }
            else 
            {
                Console.WriteLine($"odd");
            }

        }
    }
}
