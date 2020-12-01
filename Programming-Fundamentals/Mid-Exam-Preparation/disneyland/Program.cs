using System;

namespace disneyland
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savedMoney = 0;


            for (int i = 1; i <= months; i++)
            {
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }

                if (i != 1 && i % 2 == 1)
                {
                    savedMoney -= savedMoney * 0.16; 
                }

                savedMoney += money * 0.25;


            }

            if (savedMoney - money >= 0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {savedMoney - money:f2}lv. for souvenirs.");
            }

            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs(savedMoney - money):f2}lv. more.");
            }
            

            

        }
    }
}
