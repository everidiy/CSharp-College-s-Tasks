using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThreeDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: a three-digit and negative number at the same time\n");

            Console.Write(" Enter your num: ");
            double num = Convert.ToDouble(Console.ReadLine());

            bool IsThreeDigit = num > 99 || num < -99;
            bool IsNegative = num < 0;

            bool res = IsThreeDigit && IsNegative;
            Console.WriteLine($" Three-digit and negative number: {res}");
        }
    }
}
