using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Librarian : User
    {
        public int employeeNumber { get; set; }

        public void addBook(Book book, Library library)
        {
            library.Add(book);
        }
        public void removeBook(Book book, Library library)
        {
            library.Remove(book);
        }
    }
}
