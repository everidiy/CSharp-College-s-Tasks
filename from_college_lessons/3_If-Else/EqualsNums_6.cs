using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Given integers (m) and (n). \n If these numbers are not equal, replace the smaller of them with the larger original number; \n if they are equal, then replace both original numbers with zeros.\n");
            Console.Write(" Enter M-num: ");
            double M = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter N-num: ");
            double N = Convert.ToDouble(Console.ReadLine());

            double max;
            if (M != N)
            {
                if (M > N)
                {
                    max = M;
                }
                else
                {
                    max = N;
                }

                Console.WriteLine($" Not Equals: {M} != {N}");
            }
            else
            {
                M = 0;
                N = 0;

                Console.WriteLine($" Equals: {M} == {N}");
            }
        }
    }
}
