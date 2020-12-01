using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSignOfNum(n);

            static void PrintSignOfNum(int n)
            {

                if (n > 0)
                {
                    Console.WriteLine("The number {n} is positive.");
                }
                else if (n < 0)
                {
                    Console.WriteLine($"The number {n} is negative.");
                }
                else
                {
                    Console.WriteLine("The number {n} is zero.");
                }

            }
        }
    }
}
