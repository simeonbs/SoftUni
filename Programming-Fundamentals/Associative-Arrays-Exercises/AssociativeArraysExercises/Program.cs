using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            char[] array = text.ToCharArray();
            string trimmed = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (char c in trimmed)
            {
                if (dictionary.ContainsKey()
                {

                }
            }
        }
    }
}
