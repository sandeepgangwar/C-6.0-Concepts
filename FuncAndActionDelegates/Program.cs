using System;

namespace FuncAndActionDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup
            Action printText = new Action(MethodCollectios.PrintText);
            Action<int, int> printNumber = new Action<int, int>(MethodCollectios.PrintNumbers);
            Action<string> printMsg = new Action<string>(MethodCollectios.PrintMsg);
            Action<string, string> showCompleteNumber = new Action<string, string>(MethodCollectios.ShowCompleteName);
            Action<int, int> displayAddition = new Action<int, int>(MethodCollectios.DisplayAddition);
            Console.WriteLine($"---Action<>----");
            printText();
            printNumber(1, 3);
            printMsg("Hello from Main");
            showCompleteNumber("Sandeep", "Singh");
            displayAddition(11, 22);


            //Setup
            Func<int, int, int> addNumbers = new Func<int, int, int>(MethodCollectios.Add);
            Func<int> generateRandomNumber = new Func<int>(MethodCollectios.GetRandomNumber);

            Console.WriteLine($"---Func<>----");
            Console.WriteLine(addNumbers(1, 2));
            Console.WriteLine(generateRandomNumber());

        }
    }
}
