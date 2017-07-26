using System;

namespace Async
{
    public class Worker
    {
        public Worker()
        {
            work();
        }

        private void work()
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncClass.Work();
            Console.WriteLine("In main thread");
            for (int i = 0; i < 10000; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine("Main thread is completed");
        }
    }

    public class AsyncClass
    {
        public void Work()
        {
            SlowTask();
            System.Console.WriteLine($"End of {nameof(Work)}");
        }
        public void SlowTask()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);

                for (int j = 0; j < 100000; j++)
                {
                    var k = Math.Sqrt(j);
                    Console.WriteLine(k);
                }
            }
        }
    }

}
