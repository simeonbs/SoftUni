using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double pow = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerResult(num, pow));


        }

        static double PowerResult(double num, double power)
        {
            double result = 0;

            result += Math.Pow(num, power);

            return result;
        }

    }
}
