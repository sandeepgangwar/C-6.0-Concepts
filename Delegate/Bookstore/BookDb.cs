using System.Collections;

namespace Delegate.Bookstore
{
    public class BookDb
    {
        private ArrayList books = new ArrayList();

        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            books.Add(new Book(title, author, price, paperBack));
        }

        public void ProcessPaperBack(BookProcessor bookProcessor)
        {
            foreach (Book book in books)
            {
                if (book.PaperPack)
                    bookProcessor(book);
            }
        }
    }
}
