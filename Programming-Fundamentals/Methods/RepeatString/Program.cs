﻿using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, count)); 
        }
        private static string RepeatString(string str, int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += str;
                
            }

            return result;
        }
    }
}
