using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = num1 * 2.54;
            Console.WriteLine(num2);

        }
    }
}
