using System;

namespace CharactersInRange
{
    class Program
    {
        

        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            // 2 1
           
            for (int i = char1 + 1; i < char2; i++)
            {
                if (char1 > char2)
                {
                    char first = '\0';
                    char second = '\0';
                    first = char2;
                    second = char1;
                   
                    

                }

                Console.Write((char)i + " ");
            }

        }
    }
}
