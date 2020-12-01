using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double money = 0;
            double totalMoney = 0;

            if (day == "Friday")
            {
                switch (type)
                {
                    case ("Students"):
                        money += 8.45;
                        break;
                    case ("Business"):
                        money += 10.90;
                        break;
                    case ("Regular"):
                        money += 15;
                        break;
                }
            }

            else if (day == "Saturday")
            {
                switch (type)
                {
                    case ("Students"):
                        money += 9.80;
                        break;
                    case ("Business"):
                        money += 15.60;
                        break;
                    case ("Regular"):
                        money += 20;
                        break;
                }
            }

            else if (day == "Sunday")
            {
                switch (type)
                {
                    case ("Students"):
                        money += 10.46;
                        break;
                    case ("Business"):
                        money += 16;
                        break;
                    case ("Regular"):
                        money += 22.50;
                        break;
                }
            }

            if (type == "Students" && number >= 30)
            {
                money = money - (money * 0.15);
            }

            else if (type == "Business" && number >= 100)
            {
                number -= 10;
            }

            else if (type == "Regular" && number >= 10 && number <= 20)
            {
                money = money - (money * 0.05);
            }

            totalMoney = number * money;
            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}
