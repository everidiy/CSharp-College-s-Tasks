using System;

public class Rectangle
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
    }

    public double Width()
    {
        return Math.Abs(X2 - X1);
    }

    public double Height()
    {
        return Math.Abs(Y2 - Y1);
    }

    public double GetArea() 
    {
        return Width() * Height();
    } 

    public double GetSumSquaresDiagonals()
    {
        return 2 * (Math.Pow(Width(), 2) + Math.Pow(Height(), 2));
    }

    public override string ToString()
    {
        return $"Прямоугольник [({X1},{Y1}), ({X2},{Y2})], S = {GetArea()}, d = {GetSumSquaresDiagonals()}";
    }

    public int CompareTo(Rectangle other)
    {
        return GetArea().CompareTo(other.GetArea());
    }
}