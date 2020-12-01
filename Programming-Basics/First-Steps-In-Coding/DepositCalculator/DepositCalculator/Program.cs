using System;
using System.Dynamic;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depozsuma = double.Parse(Console.ReadLine());
            double srok = double.Parse(Console.ReadLine());
            double godishenprocent = double.Parse(Console.ReadLine());
            double skobi = (depozsuma * godishenprocent * 0.01 / 12);
            double prediskobi = depozsuma * srok;
            double krai = (depozsuma + srok * skobi);           

            Console.WriteLine(krai);

        }
    }
}
