using System;
using System.Threading;

namespace Events
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void SecondChangeHandler(
            object clock,
            TimeInfoEventArgs timeInfo
            );

        public event SecondChangeHandler secondChanged;

        public void Run()
        {
            for (;;)
            {
                Thread.Sleep(100);
                DateTime now = DateTime.Now;
                if (now.Second != second)
                {
                    TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(
                        now.Hour,
                        now.Minute,
                        now.Second
                        );

                    if (secondChanged != null)
                    {
                        secondChanged(this, timeInfoEventArgs);
                    }

                }
            }
        }
    }
}
