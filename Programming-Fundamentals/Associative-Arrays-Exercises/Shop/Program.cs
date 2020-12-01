using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] array = input.Split();
                string product = array[0];
                //double totalPrice = double.Parse(array[1]) * double.Parse(array[2]);
                double price = double.Parse(array[1]);
                double quantity = double.Parse(array[2]);
                

                

                if (!dictionary.ContainsKey(product))
                {
                    dictionary.Add(product, new List<double>() { price, quantity });
                }
                else
                {
                    dictionary[product][0] = price;
                    dictionary[product][1] += quantity;
                }
                

                input = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
