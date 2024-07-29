using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentbookscount = 0;

        private Book[] borrowedBooks = new Book[50];
        private int boorowedbookscount = 0;

        public void Add(Book book)
        {
            if(currentbookscount < books.Length)
            {
                books[currentbookscount] = book;
                currentbookscount++;
                Console.WriteLine("added successfully");
            }
            else
                Console.WriteLine("library is full");
        }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);

            books[index] = null;
            currentbookscount--;
            Console.Write("Book removed");
        }
        public void Display()
        {
            for (int i = 0; i < currentbookscount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }

        public void BorrowBook(Book book)
        {
            if (boorowedbookscount < borrowedBooks.Length)
            {
                borrowedBooks[boorowedbookscount] = book;
                boorowedbookscount++;
                Console.WriteLine("boorowed successfully");
            }
            else
                Console.WriteLine("sorry, you can't now");
        }
    }
}
