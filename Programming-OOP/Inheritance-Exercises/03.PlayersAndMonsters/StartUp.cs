using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Elf hero = new Elf("Sashko", 5);
            Console.WriteLine(hero);
        }
    }
}
