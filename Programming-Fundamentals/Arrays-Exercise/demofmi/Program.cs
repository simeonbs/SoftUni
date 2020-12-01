using System;
using System.Linq;

namespace demofmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hours = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string binary = Convert.ToString(hours[0], 2);
            string binary2 = Convert.ToString(hours[1], 2);
            //Console.WriteLine(binary);
            string minutes = "";
            //001011
            //0110
            //01
            string n1 = "001011";
            int output = Convert.ToInt32(n1, 2);
            //Console.WriteLine(output);

            //1|01||0011|001011


            // cikula za minutite
            for (int i = binary.Length - 5; i < binary.Length; i++)
            {
                minutes += binary[i];
            }
            int minutesToInt = Convert.ToInt32(minutes, 2);
            


            //cikula za vtorata cifra na chasovete
            string secondDigitOfHour = "";
            for (int i = binary.Length - 10; i < binary.Length - 6; i++)
            {
                secondDigitOfHour += binary[i];
            }
            int secondDigitToInt = Convert.ToInt32(secondDigitOfHour, 2);
            

            // cikula za purvata cifra na chasovete
            string firstDigitOfHour = "";
            for (int i = binary.Length - 12; i <= binary.Length - 11; i++)
            {
                firstDigitOfHour += binary[i];
            }
            int firstDigitToInt = Convert.ToInt32(firstDigitOfHour, 2);
            

            //kak izglejda chisloto
            Console.WriteLine($"{firstDigitToInt}{secondDigitToInt}:{minutesToInt}");






            //vtoriq chas
            // cikula za minutite
            string secondMinutes = "";
            for (int i = binary2.Length - 5; i < binary2.Length; i++)
            {
                secondMinutes += binary2[i];
            }
            int secondMinutesToInt = Convert.ToInt32(secondMinutes, 2);



            //cikula za vtorata cifra na chasovete
            string secondDigitOfHourSecondHour = "";
            for (int i = binary2.Length - 10; i < binary2.Length - 6; i++)
            {
                secondDigitOfHourSecondHour += binary2[i];
            }
            int secondDigitToIntSecondHour = Convert.ToInt32(secondDigitOfHourSecondHour, 2);


            // cikula za purvata cifra na chasovete
            string firstDigitOfHourSecondHour = "";
            for (int i = binary2.Length - 11; i <= binary2.Length - 10; i++)
            {
                firstDigitOfHourSecondHour += binary2[i];
            }
            int firstDigitToIntSecondHour = Convert.ToInt32(firstDigitOfHourSecondHour, 2);

            //kak izglejda vtoroto chislo
            Console.WriteLine($"{firstDigitToIntSecondHour}{secondDigitToIntSecondHour}:{secondMinutesToInt}");

            //5323 1099
            //10001001011
        }
    }
}
