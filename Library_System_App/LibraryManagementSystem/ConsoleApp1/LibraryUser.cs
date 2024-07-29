using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LibraryUser : User
    {
        public LibraryCard Card {get; set;}

        public void borrowBook(Book book, Library library)
        {
            library.BorrowBook(book);
        }
    }
}
