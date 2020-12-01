using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Method(function, n1, n2);

            static void Method(string function, int n1, int n2)
            {
                int result = 0;
                if (function == "add")
                {
                    result = n1 + n2;
                }
                else if (function == "multiply")
                {
                    result = n1 * n2;
                }
                else if (function == "subtract")
                {
                    result = n1 - n2;

                }
                else if (function == "divide")
                {
                    result = n1 / n2;
                }
                Console.WriteLine(result);
            }
        }
    }
}
