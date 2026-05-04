namespace _15_Inheritance
{
    internal class Time
    {
        internal int Minutes { get; set; }
        internal int Seconds { get; set; }

        internal int TotalSec()
        {
            return (Minutes * 60) + Seconds;
        }
    }
}
