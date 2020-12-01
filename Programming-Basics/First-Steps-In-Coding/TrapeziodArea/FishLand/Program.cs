using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqcena = double.Parse(Console.ReadLine());
            double cacacena = double.Parse(Console.ReadLine());
            double broipalamud = double.Parse(Console.ReadLine());
            double broisafrid = double.Parse(Console.ReadLine());
            double broimidi = double.Parse(Console.ReadLine());
            double palamudcena = skumriqcena + (0.6 * skumriqcena);
            double safridcena = cacacena + (0.8 * cacacena);
            double midicena = 7.50;
            double smetka = broimidi * midicena + broipalamud * palamudcena + broisafrid * safridcena;
            Console.WriteLine(smetka);


    }
}
