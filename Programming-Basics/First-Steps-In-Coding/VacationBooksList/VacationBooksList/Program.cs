using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            // read input
            double broistranici = double.Parse(Console.ReadLine());
            double stranicinachas = double.Parse(Console.ReadLine());
            double broidni = double.Parse(Console.ReadLine());
            // calculations
            double obshtovreme = broistranici / stranicinachas;
            double neobxodimo = obshtovreme / broidni;

            // output
            Console.WriteLine(neobxodimo);
        }
    }
}
