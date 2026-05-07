namespace _15_Inheritance
{
    internal class MovingObject : Time
    {
        internal double Speed { get; set; }
        internal MovingObject(double speed, int min, int sec) : base(min, sec)
        {
            Speed = speed;
        }

        internal double GetDistance()
        {
            return Speed * TotalSec();
        }
    }
}
