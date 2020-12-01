using System;

namespace ZadachaIT
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double kvadrat = a * a;
            double pravougulnik = a * b;
            double rr = r * r;
            double krug = Math.PI * rr;
            Console.WriteLine($"Skvadrat = {kvadrat}");
            Console.WriteLine($"Spravougulnik = {pravougulnik}");
            Console.WriteLine($"Skrug = {krug:F2}");
            

            
        }
    }
}
