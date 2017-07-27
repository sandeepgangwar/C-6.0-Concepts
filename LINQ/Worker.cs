using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LINQ
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {

            List<int> lstOfNumbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15
            };

            var smallNumbers = from number in lstOfNumbers
                               where number < 8
                               select number;

            foreach (var number in smallNumbers)
            {
                System.Console.WriteLine($"Number:{number}");
            }

            System.Console.WriteLine("\n --------------------------");
            var greaterNumber = lstOfNumbers
                                .Where(n => n > 8)
                                .Select(n => n);

            foreach (var number in greaterNumber)
            {
                System.Console.WriteLine($"Greater Number:{number}");
            }

            System.Console.WriteLine("\n Deffered Excution.........................");
            var million = Enumerable.Range(0, 1000000)
                .Select(x =>
                {
                    Thread.Sleep(500);
                    return x;
                });

            foreach (var number in million)
            {
                Console.Write(number);
            }
        }
    }
}
