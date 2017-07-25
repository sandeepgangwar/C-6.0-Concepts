using System;

namespace FuncAndActionDelegates
{
    public class MethodCollectios
    {
        public static void PrintText()
        {
            System.Console.WriteLine($"{nameof(PrintText)}");
        }

        public static void PrintNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                System.Console.WriteLine($"{nameof(PrintNumbers)}{i}");
            }
        }

        public static void PrintMsg(string msg)
        {
            System.Console.WriteLine($"{nameof(PrintMsg)}:{msg}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void DisplayAddition(int a, int b)
        {
            System.Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void ShowCompleteName(string fName, string lName)
        {
            System.Console.WriteLine($"Full Name {fName} {lName}");
        }

        public static int GetRandomNumber()
        {
            Random rd = new Random();
            return rd.Next();
        }
    }
}
