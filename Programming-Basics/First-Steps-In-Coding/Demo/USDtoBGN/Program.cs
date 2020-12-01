using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double rate = 1.79549;
            double bgn = usd * rate;
            Console.WriteLine($"{bgn}");
        }
    }
}
