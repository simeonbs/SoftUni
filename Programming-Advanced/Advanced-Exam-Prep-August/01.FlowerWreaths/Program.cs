using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int flowersForLater = 0;
            int wreathMade = 0;

            while (roses.Count > 0 && lilies.Count > 0)
            {
                int currRose = roses.Peek();
                int currLilie = lilies.Peek();
                int sum = currLilie + currRose;
                if (sum == 15)
                {
                    wreathMade++;
                    roses.Dequeue();
                    lilies.Pop();
                }

                if (sum > 15)
                {
                    lilies.Push(lilies.Pop() - 2);   
                }

                if (sum < 15)
                {
                    flowersForLater += sum;
                    roses.Dequeue();
                    lilies.Pop();
                }

            }

            if (flowersForLater >= 15)
            {
                wreathMade += flowersForLater / 15;
            }
            if (wreathMade >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathMade} wreaths!"); 
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathMade} wreaths more!");
            }
        }
    }
}
