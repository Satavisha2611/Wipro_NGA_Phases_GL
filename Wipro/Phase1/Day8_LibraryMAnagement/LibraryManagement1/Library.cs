using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LibraryManagement1
{
    public class Library
    {
       public List<Book> Books = new List<Book>();
       public List<Borrower> Borrowers =new List<Borrower>();

        public void AddBook(Book book)
        {
            if (!HasNull(book))
            {
                Books.Add(book);
                Console.WriteLine($"Book '{book.Title}' added successfully.");
            }
                
        }

        public void RegisterBorrower(Borrower borrower)
        {
            if (!HasNull(borrower))
            {
                Borrowers.Add(borrower);
                Console.WriteLine($"Book '{borrower.Name}' registered successfully.");
            }
        }

        public void BorrowBook(string isbn, string libraryCardNumber )
        {
           Book book = Books.FirstOrDefault(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.FirstOrDefault(bw => bw.LibraryCardNumber == libraryCardNumber);
            if (book != null && borrower != null)
            {
                borrower.BorrowedBook(book);
                Console.WriteLine("Book is successfully borrowed.");
            }
            else
            {
                Console.WriteLine($"Borrowing not valid. Book is not available or borrower not found.");
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            Book book = Books.FirstOrDefault(b => b.ISBN == isbn);
            Borrower borrower = Borrowers.FirstOrDefault(bw => bw.LibraryCardNumber == libraryCardNumber);
            if (book != null && borrower != null)
            {
                borrower.ReturnBook(book);
                Console.WriteLine("Book is successfully returned.");
            }
            else
            {
                Console.WriteLine($"Returning not valid. Book is not available or borrower not found.");
            }
        }

        public void ViewBooks()
        {
            Console.WriteLine("Books in library:");
            foreach (Book book in Books)
            {
                string status = (book.IsBorrowed) ? "Borrowed" : "In Shelf";
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Status: {status}");
            }

        }

        public void ViewBorrowers()
        {
            Console.WriteLine("Borrowers in library:");
            foreach (Borrower borrower in Borrowers)
            {
                Console.WriteLine($"Borrower name: {borrower.Name}, Library card number: {borrower.LibraryCardNumber}");
            }
        }

        public bool HasNull(object obj)
        {
            if(obj == null)
            {
                return true;
            }
            else 
            {
                return obj.GetType().GetRuntimeProperties()
                    .Any(p => p.GetValue(obj)==null);
            }
        }
    }
}
