using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] cmdArg = input.Split(" | ").ToArray();
                string command = cmdArg[0];
                string bookName = cmdArg[1];

                if (command == "Add Book")
                {
                    if (books.Contains(bookName))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        books.Insert(0, bookName);
                    }
                }

                if (command == "Take Book")
                {
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                if (command == "Swap Books")
                {
                    string firstBook = cmdArg[1];
                    string secondBook = cmdArg[2];
                    if (books.Contains(firstBook) && books.Contains(secondBook))
                    {
                        int firstIndex = books.IndexOf(firstBook);
                        int secondIndex = books.IndexOf(secondBook);
                        string book1 = books[firstIndex]; // purvata kniga
                        string book2 = books[secondIndex]; // vtorata kniga
                        string tempBook = book1;
                        books[firstIndex] = books[secondIndex]; // 1 = 2
                        books[secondIndex] = tempBook; // 2 = 1
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }

                if (command == "Insert Book")
                {
                    books.Add(bookName);
                }

                if (command == "Check Book")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index > 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
