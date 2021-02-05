using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> items = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> madeItems = new Dictionary<string, int>
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Fruit Pie", 0 },
                {"Pastry", 0 }
            };

            while (liquids.Count > 0 && items.Count > 0)
            {
                int currLiquid = liquids.Dequeue();
                int currItem = items.Pop();

                int sum = currLiquid + currItem;

                switch (sum)
                {
                    case 25:
                        madeItems["Bread"]++;
                       
                        continue;
                    case 50:
                        madeItems["Cake"]++;
                        
                        continue;
                    case 75:
                        madeItems["Fruit Pie"]++;
                        
                        continue;
                    case 100:
                        madeItems["Pastry"]++;
                        
                        continue;
                    default:
                        items.Push(currItem + 3);
                        break;
                }

                
            }

            if (!madeItems.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            if (madeItems.ContainsValue(0))
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", items)}");
            }

            foreach (var item in madeItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
