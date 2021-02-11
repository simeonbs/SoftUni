using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            Dictionary<string, int> madeBombs = new Dictionary<string, int>
            {
                {"Cherry Bombs", 0 },
                {"Datura Bombs", 0 },
                {"Smoke Decoy Bombs", 0 }
            };

            while (bombCasings.Count > 0 && bombEffects.Count > 0)
            {
                if (IsMade(madeBombs) == true)
                {
                    break;
                }

                int currEffect = bombEffects.Peek();
                int currCasing = bombCasings.Peek();
                int sum = currCasing + currEffect;

                switch (sum)
                {
                    case 40:
                        madeBombs["Datura Bombs"]++;
                        bombCasings.Pop();
                        bombEffects.Dequeue();
                        break;
                    case 60:
                        madeBombs["Cherry Bombs"]++;
                        bombCasings.Pop();
                        bombEffects.Dequeue();
                        break;
                    case 120:
                        madeBombs["Smoke Decoy Bombs"]++;
                        bombCasings.Pop();
                        bombEffects.Dequeue();
                        break;
                    default:
                        bombCasings.Push(bombCasings.Pop() - 5);
                        break;
                }
            }

            if (IsMade(madeBombs) == true)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            if (IsMade(madeBombs) == false)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count <= 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombEffects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            if (bombCasings.Count <= 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            if (bombCasings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            foreach (var item in madeBombs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            
        }

        public static bool IsMade(Dictionary<string, int> madeBombs)
        {
            if (madeBombs["Datura Bombs"] >= 3 && madeBombs["Cherry Bombs"] >= 3 && madeBombs["Smoke Decoy Bombs"] >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
