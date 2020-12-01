using System;

namespace midexam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double sum = 0;
            double clothes = 0;
            double moneyForSouvenirs = 0;
            double errorMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 2 == 1 && i != 1)
                {
                    clothes += sum * 0.16;
                    sum -= clothes;
                }
                if (i % 4 == 0)
                {
                    sum += sum * 0.25;
                }
                sum += neededMoney * 0.25;
            }
            if (sum >= neededMoney)
            {
                moneyForSouvenirs = sum - neededMoney;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyForSouvenirs:F2}lv. for souvenirs.");
            }
            else
            {
                errorMoney = neededMoney - sum;
                Console.WriteLine($"Sorry. You need {errorMoney:F2}lv. more.");
            }
            
        }
    }
}
