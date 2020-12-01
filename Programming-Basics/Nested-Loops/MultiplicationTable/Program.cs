using System;
using System.Threading;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            

            while (num2 <= 10)
            {
                int asd = num * num2;
                Console.WriteLine($"{num} X {num2} = {asd}");
                num2++;
            }

            if (num2 > 11)
            {
                int asd2 = num * num2;
                Console.WriteLine($"{num} X {num2} = {asd2}");
            }
        }
    }
}
