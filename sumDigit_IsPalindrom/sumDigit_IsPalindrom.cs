using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 678;
            int result = SumDigit(num);

            string word = "level";
            bool res = IsPalindrom(word, 0 , word.Length - 1);

            Console.WriteLine($" {result} || {res}");
        }

        static int SumDigit(int x)
        {
            x = Math.Abs(x);

            if (x <= 0) 
                return 0;

            return x % 10 + SumDigit(x / 10);
        }

        static bool IsPalindrom(string s, int left, int right)
        {
            if (left >= right)
                return true;

            if (s[left] != s[right])
                return false;

            return IsPalindrom(s, left + 1, right - 1);
        }
    }
}
