using System;
using System.Linq.Expressions;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int broiribari = int.Parse(Console.ReadLine());
            double cenanaem = 0.0;
            switch (sezon)
            {
                case "Spring":
                    cenanaem = 3000;
                    if (broiribari % 2 == 0)
                    {
                        cenanaem = cenanaem - (cenanaem * 0.05);
                    }
                    break;
                case "Summer":
                    cenanaem = 4200;
                    if (broiribari % 2 == 0)
                    {
                        cenanaem = cenanaem - (cenanaem * 0.05);
                    }
                    break;
                case "Autumn":
                    cenanaem = 4200;
                    break;
                case "Winter":
                    cenanaem = 2600;
                    if (broiribari % 2 == 0)
                    {
                        cenanaem = cenanaem - (cenanaem * 0.05);
                    }
                    break;
            }
            if (broiribari >= 6)
            {
                cenanaem = cenanaem - (cenanaem * 0.1);
            }
            if (broiribari > 7 && broiribari <= 11)
            {
                cenanaem = cenanaem - (cenanaem * 0.15);
            }
            if (broiribari > 12)
            {
                cenanaem = cenanaem - (cenanaem * 0.25);
            }
            if (budget > cenanaem)
            {
                Console.WriteLine($"Yes! You have {budget - cenanaem} leva left.");
            }
            if (cenanaem > budget)
            {
                Console.WriteLine($"Not enough money! You need {cenanaem - budget} leva.");
            }
        }
    }
}
