using Delegate.Bookstore;
using System;

namespace Delegate.BookTestClient
{
    public class PriceTotaler
    {
        private int totalBookCount = 0;
        private decimal totalBookPrice = 0.0m;

        public void AddBookTotal(Book book)
        {
            totalBookCount++;
            totalBookPrice += book.Price;
        }

        public decimal AveragePrice
        {

            get
            {
                try
                {
                    var avg = this.totalBookPrice / totalBookCount;
                    return avg;
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"{nameof(AveragePrice)} {ex.Message}");
                }

                return 0.0m;
            }


        }

    }
}
