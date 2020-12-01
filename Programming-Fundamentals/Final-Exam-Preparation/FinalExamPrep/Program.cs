using System;
using System.Linq;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] cmdArg = input.Split(">>>");
                string command = cmdArg[0];

                if (command == "Contains")
                {
                    if (text.Contains(cmdArg[1]))
                    {
                        Console.WriteLine($"{text} contains {cmdArg[1]}"); 
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);
                    if (cmdArg[1] == "Upper")
                    {
                        char[] charArr = text.ToCharArray();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            charArr[i] = char.ToUpper(charArr[i]);
                        }
                        text = new string(charArr);
                        Console.WriteLine(text);
                    }

                    else if (cmdArg[1] == "Lower")
                    {
                        char[] charArr = text.ToCharArray();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            charArr[i] = char.ToLower(charArr[i]);
                            
                        }
                        text = new string(charArr);
                        Console.WriteLine(text);
                        
                    }
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    int count = text.IndexOf(text[endIndex]) - startIndex;
                    text = text.Remove(startIndex, count);
                    
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(text);
        }
    }
}
