using System;
using System.Threading;

public class RectangleWithCircle : Rectangle
{
    public double R { get; set; }

    public RectangleWithCircle(double x1, double y1, double x2, double y2, double r)
        : base(x1, y1, x2, y2)
    {
        if (r >= Width() || r >= Height())
            throw new ArgumentException("Радиус круга должен быть меньше сторон прямоугольника.");
        R = r;
        Thread.Sleep(1000);
    }

    public double GetDifferenceArea()
    {
        double circleArea = Math.PI * Math.Pow(R, 2);
        return GetArea() - circleArea;
    }

    public override string ToString()
    {
        return $"Фигура (Прям.+Круг R={R}), S_фигуры = {GetDifferenceArea()}, " + base.ToString();
    }
}