using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class TakeTest
    {
        public static void Test()
        {
            List<int> numbers = new List<int>
            {
                1,2,3,4,5
            };

            var take2 = numbers.Take(2);

            foreach (var item in take2)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
