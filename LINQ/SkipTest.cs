using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class SkipTest
    {
        public static void Test()
        {
            List<int> numbers = new List<int>
            {
                2,3,4,5,45
            };

            var skipNumbers = numbers.SkipWhile(t => t < 4);

            System.Console.WriteLine("Skip-------------------------");
            foreach (var item in skipNumbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
