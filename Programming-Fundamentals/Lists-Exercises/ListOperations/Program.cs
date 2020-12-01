using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();
                string operation = command[0];

                switch (operation)
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        list.Add(numberToAdd);
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);
                        int number = int.Parse(command[1]);
                        if (index >= 0 && index <= list.Count - 1)
                        {
                            list.Insert(index, number);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (indexToRemove >= 0 && indexToRemove <= list.Count - 1)
                        {
                            list.RemoveAt(indexToRemove);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                // 1 2 3
                                // 2 3 1
                                int firstNumber = list[0];
                                list.Add(firstNumber);
                                list.RemoveAt(0);

                            }
                        }
                        else
                        {
                            
                            for (int i = 0; i < count; i++)
                            {
                                // 1 2 3
                                // 3 1 2 
                                // 3 1 2
                                int lastNumber = list[list.Count - 1];
                                list.Insert(0, lastNumber);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;






                    default:
                        break;
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
