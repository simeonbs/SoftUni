using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            PrintPrice(product, quantity);

            static void PrintPrice(string product, double quantity)
            {
                double endPrice = 0;
                switch (product)
                {
                    case ("coffee"):
                        endPrice = quantity * 1.50;
                        break;
                    case ("water"):
                        endPrice = quantity * 1.00;
                        break;
                    case ("coke"):
                        endPrice = quantity * 1.40;
                        break;
                    case ("snacks"):
                        endPrice = quantity * 2.00;
                        break;

                }
                Console.WriteLine($"{endPrice:F2}");
            }
        }
    }
}
