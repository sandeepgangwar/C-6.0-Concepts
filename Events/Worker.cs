namespace Events
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Clock clock = new Clock();
            DigitalClock dc = new DigitalClock();
            dc.Subscribe(clock);
            Logger logger = new Logger();
            logger.Subscribe(clock);
            clock.Run();
        }
    }
}
