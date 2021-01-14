using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            int doneCount = 0;

            while (command != "end")
            {


                if (command == "green")
                {

                    for (int i = 0; i < count; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            doneCount++;
                        }

                    }
                    command = Console.ReadLine();
                    continue;





                }



                queue.Enqueue(command);



                command = Console.ReadLine();
            }


            Console.WriteLine($"{doneCount} cars passed the crossroads.");
        }
    }
}
