using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Enter two numbers. If their sum is greater than 100, \n then reduce the sum by half; otherwise, reduce it by two.\n");
            Console.Write(" Enter first num: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter first num: ");
            double second = Convert.ToDouble(Console.ReadLine());

            double res = first + second > 100 ? (first + second) / 2 : (first + second) - 2;
            Console.WriteLine($" Result: {res}");
        }
    }
}
