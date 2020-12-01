using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string cvetq = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double harch = 0.0;

            switch (cvetq)
            {
                case "Roses":
                    if (broi > 80)
                    {
                        harch = (broi * 5) - 0.1 * (broi * 5);
                    }
                    break;
                case "Dahlias":
                    if (broi > 90)
                    {
                        harch = (broi * 3.80) - 0.15 * (broi * 3.80);
                    }
                    break;
                case "Tulips":
                    if (broi > 80)
                    {
                        harch = (broi * 2.80) - 0.15 * (broi * 2.80);
                    }
                    break;
                case "Narcissus":
                    if (broi > 120)
                    {
                        harch = (broi * 3) + 0.15 * (broi * 3);
                    }

                    break;


            }
            if (budget > harch)
            {
                Console.WriteLine(harch);
            }



        }
    }
}
