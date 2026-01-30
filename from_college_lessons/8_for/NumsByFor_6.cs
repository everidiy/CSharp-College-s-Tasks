using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsByFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: N and X; S = sinX + sinsinX + ... + (sinsin...sinX) by N times\n");
            
            Console.Write(" Enter natural num: ");
            int NNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter real num: ");
            double RNum = Convert.ToDouble(Console.ReadLine());

            double S = 0;
            double current = RNum;

            for (int i = 0; i < NNum; i++)
            {
                current = Math.Sin(current);
                S += current;
            }

            Console.WriteLine($"\n Sum S = {S}");
        }
    }
}
