using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumDivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Get all the divisors of a given number in descending order\n");
            Console.Write(" Enter a num: ");

            double num = Convert.ToDouble(Console.ReadLine());
            double x = num;

            while (x >= 1)
            {
                if (num % x == 0)
                {
                    Console.WriteLine($" Your num divided by {x} is {num / x}");
                }
                x--;
            }
        }
    }
}
