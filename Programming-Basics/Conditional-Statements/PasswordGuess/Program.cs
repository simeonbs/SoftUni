using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string corrPass = "s3cr3t!P@ssw0rd";
            if (password == corrPass) 
            {
                Console.WriteLine($"Welcome");
            }
            else
            {
                Console.WriteLine($"Wrong password!");
            }
        }
    }
}
