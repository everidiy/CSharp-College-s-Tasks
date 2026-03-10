using System;

namespace DoubleMethods
{
    internal class Program
    {
        static void Main()
        {
            Console.Write($" Введите сторону равностороннего треугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($" Его площадь - {EquilateralTriangleArea(a)}\n");

            Console.WriteLine($" Площадь правильного шестиугольника - {EquilateralTriangleArea(a)} * 6 = {EquilateralTriangleArea(a) * 6}");
        }

        static double EquilateralTriangleArea(double side)
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
        }
    }
}

