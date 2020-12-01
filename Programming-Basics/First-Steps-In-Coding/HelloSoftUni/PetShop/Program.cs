using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double kucheta = double.Parse(Console.ReadLine());
            double drugi = double.Parse(Console.ReadLine());
            double neobxodimok = kucheta * 2.50;
            double neobxodimod = drugi * 4;
            double kraino = neobxodimod + neobxodimok;

            Console.WriteLine($"{kraino} lv.");






        }
    }
}
