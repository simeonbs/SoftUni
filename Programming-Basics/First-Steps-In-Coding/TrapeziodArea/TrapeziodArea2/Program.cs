using System;

namespace TrapeziodArea2
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
            double midisuma = broimidi * midicena;
            double palamudsuma = broipalamud * palamudcena;
            double safridsuma = broisafrid * safridcena;
            double smetka = midisuma + palamudsuma + safridsuma;
            Console.WriteLine(Math.Round(smetka, 2));
        }
    }
}
