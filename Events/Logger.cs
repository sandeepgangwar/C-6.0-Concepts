namespace Events
{
    public class Logger
    {

        public void Subscribe(Clock clock)
        {
            clock.secondChanged += LogTime;
        }

        public void LogTime(object clock, TimeInfoEventArgs timeInfoEventArgs)
        {
            System.Console.WriteLine($"Logging {timeInfoEventArgs.Hour.ToString()}:{timeInfoEventArgs.Minute.ToString()}:{timeInfoEventArgs.Second.ToString()}");
        }
    }
}
