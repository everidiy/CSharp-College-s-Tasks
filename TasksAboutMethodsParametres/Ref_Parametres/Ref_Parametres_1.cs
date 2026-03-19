using System;

namespace ReducingAFractionToAnIrreducibleForm
{
    internal class Program
    {
        static void Main()
        {
            int num = 8;
            int den = -12;

            Console.WriteLine($"До: {num}/{den}");

            ReduceFraction(ref num, ref den);

            Console.WriteLine($"После: {num}/{den}");
        }

        static void ReduceFraction(ref int num, ref int den)
        {
            if (den == 0)
                throw new ArgumentException("Знаменатель не может быть 0");

            int gcd = GCD(num, den);

            num /= gcd;
            den /= gcd;

            if (den < 0)
            {
                num = -num;
                den = -den;
            }
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
    }
}
