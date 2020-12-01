using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double zala = double.Parse(Console.ReadLine());
            double torta = zala * 0.2;
            double napitki = torta - (0.45 * torta);
            double animator = zala / 3;
            double krai = zala + torta + napitki + animator;
            Console.WriteLine(krai);

        }
    }
}
