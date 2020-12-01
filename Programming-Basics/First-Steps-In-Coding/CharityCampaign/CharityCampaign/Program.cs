using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double broidni = double.Parse(Console.ReadLine());
            double broisladkari = double.Parse(Console.ReadLine());
            double broitorti = double.Parse(Console.ReadLine());
            double broigufreti = double.Parse(Console.ReadLine());
            double broipalachinki = double.Parse(Console.ReadLine());
            double torta = 45;
            double gufreta = 5.80;
            double palachinka = 3.20;
            double prodadenitorti = torta * broitorti;
            double prodadenigufreti = gufreta * broigufreti;
            double prodadenipalachinki = broipalachinki * palachinka;
            double sumazaedinden = (torta * broitorti + gufreta * broigufreti + palachinka * broipalachinki) * broisladkari ;
            double sumazacqlatakampaniq = sumazaedinden * broidni;
            double sumazzacqlatakampaniqsledsmetka = sumazacqlatakampaniq * 1 / 8;
            double sumasledrazhodi = (sumazacqlatakampaniq - sumazzacqlatakampaniqsledsmetka);
            Console.WriteLine(sumasledrazhodi);
        }
    }
}
