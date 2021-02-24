using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());


            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine(box);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            

            //Volume = lwh
            //Lateral Surface Area = 2lh + 2wh
            //Surface Area = 2lw + 2lh + 2wh
        }
    }
}
