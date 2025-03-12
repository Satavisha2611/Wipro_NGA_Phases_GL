using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    public class Book
    {
        public string Title { get;  set; }

        public string Author { get;  set; }

        public string ISBN {  get;  set; }

        public bool IsBorrowed { get; set; }

        public Book(string title, string author,string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.IsBorrowed = false;
        }

        public void Borrow()
        { 
           IsBorrowed = true;
        }

        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
