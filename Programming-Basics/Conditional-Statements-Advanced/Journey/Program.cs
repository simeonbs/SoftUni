using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string accomodation = "";

            double expenses = 0.0;
            if (budget <= 100)
            {
                location = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    expenses = budget * 0.3;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    expenses = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                location = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    expenses = budget * 0.4;
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    expenses = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                location = "Europe";
                accomodation = "Hotel";
                expenses = 0.9 * budget;
            }
            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{accomodation} - {expenses:F2}");

        }
    }
}
