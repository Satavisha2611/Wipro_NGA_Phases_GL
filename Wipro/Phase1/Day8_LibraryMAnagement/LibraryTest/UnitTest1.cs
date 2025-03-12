using LibraryManagement1;
using NUnit.Framework;
namespace LibraryTest
{
    public class Tests
    {
        private Library lib_;
        private Book book_;
        private Borrower borrower_;
        [SetUp]
        public void SetUp()
        {
            lib_ = new Library();
            book_ = new Book("The Great Gatsby", "Fritz", "12345" );
            borrower_ = new Borrower("Satavisha", "L001");

            lib_.AddBook(book_);
            lib_.RegisterBorrower(borrower_);
        }

        
        [Test]
        public void Test_AddBook()
        {
            Assert.That(lib_.Books, Does.Contain(book_));
        }
        [Test]
        public void Test_RegisterBorrower()
        {
            Assert.That(lib_.Borrowers, Does.Contain(borrower_));
        }

        [Test]
        public void Test_BorrowerBook()
        {
            lib_.BorrowBook("12345", "L001");
            bool res = borrower_.Borrowedbooks.Contains(book_);
            Assert.That(res, Is.True);
            Assert.That(borrower_.Borrowedbooks,Does.Contain(book_));
        }
        [Test]
        public void Test_ReturnBook()
        {
            lib_.BorrowBook("12345", "L001");
            lib_.ReturnBook("12345", "L001");

           bool res= borrower_.Borrowedbooks.Contains(book_);
            Assert.That(res, Is.False);
        }
        [Test]
        public void Test_ViewBooks_VieBorrowers()
        {
            Assert.That(1 == lib_.Books.Count);
            Assert.That(1 == lib_.Borrowers.Count);
        }
    }
}
