using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projekciq = Console.ReadLine();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (projekciq == "Premiere")
            {
                income = redove * koloni * 12.00;

            }
            else if (projekciq == "Normal")
            {
                income = redove * koloni * 7.50;
            }
            else if (projekciq == "Discount")
            {
                income = redove * koloni * 5.00;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
