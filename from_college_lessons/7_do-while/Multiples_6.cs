using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Find all multiples of 5 for numbers from 1 to N\n");
            Console.Write(" Enter N-edge: ");

            int edge = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (edge % 5 == 0)
                {
                    Console.WriteLine($" {edge} is divisible by 5, result: {edge / 5}");
                }
                edge--;
                
            } while (edge >= 1);
        }
    }
}
