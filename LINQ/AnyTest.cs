using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class AnyTest
    {
        public static void Test()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int>();
            bool any3 = list1.Any(x => x == 4);
            System.Console.WriteLine($"{list1.Any()}:{list2.Any()}:{any3}");
        }
    }
}
