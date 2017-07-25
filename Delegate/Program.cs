using Delegate.Bookstore;

namespace Delegate
{
    class Program
    {
        internal static void PrintTitle(Book book)
        {
            System.Console.WriteLine($"Title:{book.Title}");
        }

        static void Main(string[] args)
        {
            BookDb db = new BookDb();
            db.AddBook("C# v.10", "Mike", 23.34m, true);
            db.AddBook("C# v.20", "Hang", 14.34m, false);
            db.AddBook("C# v.30", "Shu", 15.34m, true);
            db.AddBook("C# v.40", "Lee", 17.34m, true);


            //Normal approach

            //Console.WriteLine("Printing title...");
            //db.ProcessPaperBack(new BookProcessor(PrintTitle));
            //Console.WriteLine("Printing total...");
            //PriceTotaler pt = new PriceTotaler();
            //db.ProcessPaperBack(new BookProcessor(pt.AddBookTotal));
            //Console.WriteLine($"Paperback book avg price:{pt.AveragePrice}");

            //Using the power of composition

            //PriceTotaler pt = new PriceTotaler();
            //BookProcessor bp = new BookProcessor(pt.AddBookTotal) + new BookProcessor(PrintTitle);
            //db.ProcessPaperBack(bp);


            //CompositeDelegateTestClient.Test();

        }
    }
}
