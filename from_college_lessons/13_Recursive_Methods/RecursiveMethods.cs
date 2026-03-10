using System;

namespace RecursiveMethods
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            int A = rnd.Next(-10, 10);
            int B = rnd.Next(-10, 10);

            Console.WriteLine($" Число А = {A}");
            Console.WriteLine($" Число B = {B}");
            Console.WriteLine();

            if (A < B)
            {
                Console.Write(" Возрастание: ");
                ToHigh(A, B);
                Console.WriteLine();
            } else
            {
                Console.Write(" Убывание: ");
                ToLow(A, B);
                Console.WriteLine();
            }
        }

        static void ToHigh(int a, int b)
        {
            if (a > b) return;

            Console.Write($" {a} ");

            ToHigh(a + 1, b);
        }

        static void ToLow(int a, int b)
        {
            if (a < b) return;

            Console.Write($" {a} ");

            ToLow(a - 1, b);
        }
    }
}
