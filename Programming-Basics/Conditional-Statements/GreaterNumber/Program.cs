using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int purvo = int.Parse(Console.ReadLine());
            int vtoro = int.Parse(Console.ReadLine());
            if (purvo > vtoro)
                {
                Console.WriteLine(purvo);

                }
            else
            {
                Console.WriteLine(vtoro);
            }
        }
    }
}
