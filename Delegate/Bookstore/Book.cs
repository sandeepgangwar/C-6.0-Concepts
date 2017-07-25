namespace Delegate.Bookstore
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public bool PaperPack { get; set; }

        public Book(string title, string author, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            PaperPack = paperBack;

        }
    }
}
