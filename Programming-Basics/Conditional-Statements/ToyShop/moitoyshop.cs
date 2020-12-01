using System;

namespace ToyShop
{
    class moitoyshop
    {
        static void Main(string[] args)
        {
            double ekskurziqcena = double.Parse(Console.ReadLine());
            double broipuzeli = double.Parse(Console.ReadLine());
            double broigovoreshtikukli = double.Parse(Console.ReadLine());
            double broiplushenimecheta = double.Parse(Console.ReadLine());
            double broiminioni = double.Parse(Console.ReadLine());
            double broikamioncheta = double.Parse(Console.ReadLine());
            double puzelcena = 2.60;
            double kuklicena = 3;
            double mechetacena = 4.10;
            double kamionchecena = 2;
            double minioncena = 8.20;

            double puzel = puzelcena * broipuzeli;
            double kukli = kuklicena * broigovoreshtikukli;
            double mecheta = mechetacena * broiplushenimecheta;
            double kamionche = kamionchecena * broikamioncheta;
            double minion = minioncena * broiminioni;

            double pechalba = puzel + kukli + mecheta + kamionche + minion;


            if (pechalba >= 50)
            {
                pechalba = pechalba - (0.25 * pechalba);
            }

            pechalba -= (pechalba * 0.1);
            
            if (pechalba >= ekskurziqcena)
            {
                Console.WriteLine($"Yes! {(pechalba - ekskurziqcena):F2} lv left.");
            }
            else if (pechalba < 0)
            {
                Console.WriteLine($"Not enough money! {(ekskurziqcena - pechalba):F2} lv needed.");
            }
        }
    }
}
