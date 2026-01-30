using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: \n Z = k^2 / (m + sqrt(n))\n");
            Console.Write(" Enter K-num: ");
            double K = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter M-num: ");
            double M = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter N-num: ");
            double N = Convert.ToDouble(Console.ReadLine());


            double first = Math.Pow(K, 2);
            double second = (M + Math.Sqrt(N));
            double res = first / second;
            Console.WriteLine($" {res}");
        }
    }
}
