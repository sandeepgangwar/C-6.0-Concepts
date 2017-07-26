namespace Events
{
    public class DigitalClock
    {
        public void Subscribe(Clock clock)
        {
            clock.secondChanged += newTime;
        }

        public void newTime(object clock, TimeInfoEventArgs timeInfoEventArgs)
        {
            System.Console.WriteLine($"Current time:{timeInfoEventArgs.Hour.ToString()}:{timeInfoEventArgs.Minute.ToString()}:{timeInfoEventArgs.Second.ToString()}");
        }
    }
}
