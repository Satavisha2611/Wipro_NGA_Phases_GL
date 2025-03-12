using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    public class Borrower
    {
        public string Name {  get; set; }
        public string LibraryCardNumber { get; set; }

        public List<Book> Borrowedbooks;
        public Borrower(string name, string libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
            Borrowedbooks = new List<Book>();
        }

       

        public void BorrowedBook(Book book)
        {
            
            book.Borrow();
            Borrowedbooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            book.Return();
            Borrowedbooks.Remove(book);
        }
    }
}
