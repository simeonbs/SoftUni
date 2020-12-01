using System;

namespace computerstore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double priceWithoutTaxes = 0;
            double taxes = 0;
            double priceWithTaxes = 0;
            double allTaxes = 0;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);
                //priceWithoutTaxes += price;

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;

                }
                else
                {
                    priceWithoutTaxes += price;
                }

                taxes = price * 0.2;
                allTaxes += taxes;

                command = Console.ReadLine();
            }

            priceWithTaxes = priceWithoutTaxes + allTaxes;
            if (command == "special")
            {
                priceWithTaxes = priceWithTaxes - priceWithTaxes * 0.1;
            }

            if (priceWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }


            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaxes:F2}$");
            Console.WriteLine($"Taxes: {allTaxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {priceWithTaxes:F2}$");



        }
    }
}

