using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            double health = 100;
            double bitcoins = 0;

            string[] rooms = Console.ReadLine().Split("|").ToArray();

            

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] cmdArg = rooms[i].Split();
                string command = cmdArg[0];
                int number = int.Parse(cmdArg[1]);
                if (command == "potion")
                {
                    if (number + health <= 100)
                    {
                        health += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        // 90hp
                        // 30hp
                        
                        
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }

                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }

                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
