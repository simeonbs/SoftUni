using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                if (count >= 4 && lift[i] == 0)
                {
                    count -= 4;
                    lift[i] += 4;
                }
                else if (count >= 3 && lift[i] <= 1)
                {
                    count -= 3;
                    lift[i] += 3;
                }
                else if (count >= 2 && lift[i] == 2)
                {
                    count -= 2;
                    lift[i] += 2;
                }
                else if (count >= 1 && lift[i] == 3)
                {
                    count -= 1;
                    lift[i] += 1;
                }

            }

            if (lift.Contains(3) || lift.Contains(2) || lift.Contains(1) || lift.Contains(0))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (count > 0)
            {
                Console.WriteLine($"There isn't enough space! {count} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
