using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class DistinctTest
    {
        public static void Test()
        {
            List<int> lst = new List<int>
            {
                1,1,3,4,4
            };

            var dist = lst.Distinct();
            foreach (var item in dist)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}
