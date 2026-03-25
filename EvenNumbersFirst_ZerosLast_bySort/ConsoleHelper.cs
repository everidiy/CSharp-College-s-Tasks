using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersFirst_ZerosLast_bySort
{
    internal class ConsoleHelper
    {
        public static void PrintCentered(string text) 
        {
            int leftPadding = (Console.WindowWidth - text.Length) / 2;

            if (leftPadding < 0)
                leftPadding = 0;

            Console.WriteLine(new string(' ', leftPadding) + text);
        }
    }
}
