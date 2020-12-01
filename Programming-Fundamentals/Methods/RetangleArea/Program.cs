using System;
using System.Transactions;

namespace RetangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRetangleArea(width, height);
            Console.WriteLine(area);

            static double GetRetangleArea(double width, double height)
            {
                return width * height;
            }
        }
    }
}
