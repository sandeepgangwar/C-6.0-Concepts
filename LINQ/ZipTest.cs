using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class ZipTest
    {
        public static void Test()
        {
            List<string> codes = new List<string>
            {
                "Az",
                "Hs",
                "TX"
            };

            List<string> states = new List<string>
            {
                "Arizona",
                "Houstan",
                "Texas"
            };

            var codeWithDescs = codes.Zip(states, (code, state) => $"{code}:{state}");

            foreach (var item in codeWithDescs)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
