namespace _15_Inheritance
{
    internal class Time
    {
        internal int Minutes { get; set; }
        internal int Seconds { get; set; }

        internal Time(int min, int sec)
        {
            Minutes = min;
            Seconds = sec;
        }

        internal int TotalSec()
        {
            return (Minutes * 60) + Seconds;
        }
    }
}
