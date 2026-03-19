using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Дискриминант через параметры out");

            int D = 0;
            double x1 = 0;
            double x2 = 0;

            SolveQuadratic(10, 13, 4, out D, out x1, out x2);
            Console.WriteLine($"D: {D} | x1: {x1} | x2: {x2}");
        }

        static void SolveQuadratic(double a, double b, double c, out int rootCount, 
        out double x1, out double x2)
        {
            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                rootCount = 0;
                x1 = x2 = 0;
            }
            else if (D == 0)
            {
                rootCount = 1;
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                rootCount = 2;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
        }
    }
}
