namespace Delegate.CompositeDelegateTest
{
    public delegate void CompositeDelegate(string str);
    public static class CompositeDelegateTestClient
    {
        public static void SayHello(string str)
        {
            System.Console.WriteLine($"{nameof(SayHello)}:{str}");
        }

        public static void SayGoodBye(string str)
        {
            System.Console.WriteLine($"{nameof(SayGoodBye)}:{str}");
        }

        public static void Test()
        {
            CompositeDelegate a, b, c, d;
            a = new CompositeDelegate(SayHello);
            b = new CompositeDelegate(SayGoodBye);
            c = a + b;
            d = c - a;
            System.Console.WriteLine($"a");
            a("demo");
            System.Console.WriteLine($"b");
            b("demo");
            System.Console.WriteLine($"c");
            c("demo");
            System.Console.WriteLine($"d");
            d("demo");

        }
    }
}
