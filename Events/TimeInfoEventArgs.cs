namespace Events
{
    public class TimeInfoEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public TimeInfoEventArgs(int hr, int min, int sec)
        {
            Hour = hr;
            Minute = min;
            Second = sec;
        }
    }
}
