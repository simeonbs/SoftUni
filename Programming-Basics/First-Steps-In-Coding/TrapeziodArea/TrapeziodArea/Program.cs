using System;

namespace TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double skobi = b1 + b2;
            double formula = (skobi * h) / 2;
            Console.WriteLine($"{formula:F2}");

        }
    }
}
