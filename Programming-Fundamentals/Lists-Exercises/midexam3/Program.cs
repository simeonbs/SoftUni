using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace midexam3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            string[] command = Console.ReadLine().Split("|").ToArray();

            while (command[0] != "Done")
            {
                if (command[0] == "Add Book ")
                {
                    string firstBook = command[1];
                    books.Insert(0, firstBook);
                }

                else if (command[0] == "Take Book ")
                {
                    string currentBook = command[1];
                    if (books.Contains(currentBook))
                    {
                        books.Remove(currentBook);
                    }
                    else
                    {
                        break;
                    }
                }

                else if (command[0] == "Swap Books ")
                {
                    string book1 = command[1];
                    string book2 = command[2];

                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        int indexOfFirst = books.IndexOf(book1);
                        int indexOfSecond = books.IndexOf(book2);
                        string temp1 = books[indexOfFirst];
                        string temp2 = books[indexOfSecond];
                        books[indexOfFirst] = temp2;
                        books[indexOfSecond] = temp1;
   
                    }
                }

                else if (command[0] == "Insert Book ")
                {
                    string bookName = command[1];
                    books.Add(bookName);
                }

                else if (command[0] == "Check Book ")
                {
                    string bookNeeded = command[1];
                    if (books.Contains(bookNeeded))
                    {
                        Console.WriteLine(bookNeeded);
                    }
                    else
                    {
                        break;
                    }
                }

                command = Console.ReadLine().Split("|").ToArray();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
