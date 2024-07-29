using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Library managment system! ");

            Library library = new Library();
            

            Console.Write("Are you librarian or regular user? (L/R):  ");
            string userChoise= Console.ReadLine().ToUpper();
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"\t\t\t\t\tWelcome {userName}");

            while(true)
            {
                if (userChoise == "L")
                {

                    Librarian librarian = new Librarian();


                    Console.WriteLine($"choose: 1-Add (1).  \t  2-Remove (2). \t  3-Display(3)");
                    int actionChoise = int.Parse(Console.ReadLine());

                    switch (actionChoise)
                    {
                        case 1:
                            Console.WriteLine("Enter title, autor and year: ");
                            Console.Write("Enter the title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter the name of author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter the year of book: ");
                            int year = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = title,
                                Author = author,
                                Year = year
                            };

                            librarian.addBook(book, library);
                            break;
                        case 2:
                            Console.WriteLine("Enter title, autor and year: ");
                            Console.Write("Enter the title: ");
                            title = Console.ReadLine();
                            Console.Write("Enter the name of author: ");
                            author = Console.ReadLine();
                            Console.Write("Enter the year of book: ");
                            year = int.Parse(Console.ReadLine());

                            book = new Book()
                            {
                                Title = title,
                                Author = author,
                                Year = year
                            };

                            librarian.removeBook(book, library);
                            break;

                        case 3:
                            librarian.DisplayBooks(library);

                            break;
                        default:
                            Console.WriteLine("Please enter right value!");
                            break;
                    }


                }
                else if (userChoise == "R")
                {
                    LibraryUser libraryUser = new LibraryUser();

                    Console.WriteLine($"choose: 1-Display (1).  \t  2-Borrow(2).");
                    int actionChoise = int.Parse(Console.ReadLine());

                    switch (actionChoise)
                    {
                        case 1:
                            library.Display();
                            break;
                        case 2:
                            Console.WriteLine("Enter title, autor and year: ");
                            Console.Write("Enter the title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter the name of author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter the year of book: ");
                            int year = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = title,
                                Author = author,
                                Year = year
                            };

                            library.BorrowBook(book);
                            break;
                        default:
                            Console.WriteLine("Please enter right value!");
                            break;
                    }
                }
                else
                    Console.WriteLine("write L or R only");
            }

            
        }
    }
}
