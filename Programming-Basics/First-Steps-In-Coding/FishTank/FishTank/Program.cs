using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double duljina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double obem = duljina * shirochina * visochina;
            double obshtolitri = obem * 0.001;
            double umnojeniprocenti = procent * 0.01;
            double litri = obshtolitri * (1 - umnojeniprocenti);
            Console.WriteLine(litri);
        }
    }
}
