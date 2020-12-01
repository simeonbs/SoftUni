using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaqgodi = double.Parse(Console.ReadLine());
            double kolichestvobanani = double.Parse(Console.ReadLine());
            double kolichestvoportokali = double.Parse(Console.ReadLine());
            double kolichestvomalini = double.Parse(Console.ReadLine());
            double kolichestvoqgodi = double.Parse(Console.ReadLine());
            double cenamalini = (0.5 * cenaqgodi);
            double cenaportokali = cenamalini - (0.4 * cenamalini);
            double cenabanani = cenamalini - (0.8 * cenamalini);
            double sumaqgodi = cenaqgodi * kolichestvoqgodi;
            double sumabanani = kolichestvobanani * cenabanani;
            double sumamalini = kolichestvomalini * cenamalini;
            double sumaportokali = kolichestvoportokali * cenaportokali;
            double kraina = sumaqgodi + sumaportokali + sumamalini + sumabanani;
            kraina = Math.Round(kraina, 2);
            Console.WriteLine(kraina);


        

        }
    }

}
