using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement1;

namespace LibraryManagement_Main
{
    internal class Program
    {


       
            
        static void Main(string[] args)
        {
            Library lib = new LibraryManagement1.Library();

            Console.WriteLine("Library Management:");
            Console.WriteLine("1.Add books ");
            Console.WriteLine("2.Register people");
            Console.WriteLine("3.View books");
            Console.WriteLine("4.View borrowers");
            Console.WriteLine("5.Borrow book");
            Console.WriteLine("6.Return book");
            Console.WriteLine("7.Exit");
            bool noExit = true;
            while(noExit)
            {
                int ch = 7;
                Console.WriteLine("Enter your choice");
                try
                {
                    ch = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                switch(ch)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter book title:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter book author:");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter book ISBN:");
                            string isbn = Console.ReadLine();
                            Book b = new Book(title, author, isbn);
                            lib.AddBook(b);
                            noExit = true;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter library card number:");
                            string librarycardnumber = Console.ReadLine();
                            Borrower bo = new Borrower(name, librarycardnumber);
                            lib.RegisterBorrower(bo);
                            noExit = true;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:
                        lib.ViewBooks();
                        noExit = true;
                        break;

                    case 4:
                        lib.ViewBorrowers();
                        noExit = true;
                        break;
                    
                    case 5:
                        try
                        {
                            Console.WriteLine("Enter book's ISBN:");
                            string boIsbn = Console.ReadLine();
                            Console.WriteLine("Enter borrower's library card number:");
                            string boLibrarycardnumber = Console.ReadLine();
                            lib.BorrowBook(boIsbn, boLibrarycardnumber);
                            noExit = true;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 6:
                        try
                        {
                            Console.WriteLine("Enter book's ISBN:");
                            string boIsbn1 = Console.ReadLine();
                            Console.WriteLine("Enter borrower's library card number:");
                            string boLibrarycardnumber1 = Console.ReadLine();
                            lib.ReturnBook(boIsbn1, boLibrarycardnumber1);
                            noExit = true;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 7:
                        Console.WriteLine("Exitting");
                        noExit = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
