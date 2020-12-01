using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(PrintVowelsCount(input));

        }

        private static int PrintVowelsCount(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    counter++;
                }
                else if (input[i] == 'e')
                {
                    counter++;
                }
                else if (input[i] == 'i')
                {
                    counter++;
                }
                else if (input[i] == 'o')
                {
                    counter++;
                }
                else if (input[i] == 'u')
                {
                    counter++;
                }
                else if (input[i] == 'y')
                {
                    counter++;
                }
                

            }
            return counter;
        }
    }
}
