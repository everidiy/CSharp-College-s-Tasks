using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int num = 567;
            Console.WriteLine(DivisibleBy7(num));
        }

        static bool DivisibleBy7(int num)
        {
            //int res = 0;

            //string strLength = num.ToString();
            //int lastNum = int.Parse(strLength[strLength.Length - 1].ToString());

            //res = (num / 10) - (lastNum * 2);

            //Console.WriteLine(res);

            //return res % 7 == 0;

            if (num == 0 || num == 7) return true;
            if (num < 10) return false;
            if (num < 0) num = -num;

            int lastDigit = num % 10;
            int remaining = num / 10;

            int newNum = remaining - 2 * lastDigit;

            return DivisibleBy7(num);
        }
    }
}
