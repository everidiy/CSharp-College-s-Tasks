using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hanoi
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("==ХАНОЙСКАЯ=БАШНЯ==");
            Console.Write("Введите количество дисков (1-10): ");
            int desks = Convert.ToInt32(Console.ReadLine());

            if (desks <= 0 || desks > 10) return;

            Loading();

            char[] symbols = { 'A', 'B', 'C' };

            char from = symbols[0];
            char temp = symbols[1];
            char to = symbols[2];

            GetStepsCount(desks, from, temp, to);
        }

         static void Loading()
        {
            Console.Clear();

            Console.WriteLine("    |          |         |    ");
            Console.WriteLine("   ###         |         |    ");
            Console.WriteLine("  #####        |         |    ");
            Console.WriteLine(" #######       |         |    ");
            Console.WriteLine("========== ========= =========");
            Console.WriteLine("    A          B         C    \n");

            Console.Write("Перекладываем");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }

            Console.Clear();

            Console.WriteLine("    |          |          |    ");
            Console.WriteLine("    |          |         ###   ");
            Console.WriteLine("    |          |        #####  ");
            Console.WriteLine("    |          |       ####### ");
            Console.WriteLine("========== ========== =========");
            Console.WriteLine("    A          B          C    \n");

            Console.Write("Подсчитываем");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
            Console.WriteLine("\n");
        }

        private static int move = 0;

        static void GetStepsCount(int desks, char from, char to, char aux)
        {
            if (desks == 0) return;

            GetStepsCount(desks - 1, from, to, aux);
            move++;
            if (move < 10)
            {
                Console.WriteLine($"{from} -> {to} | Step 0{move}");
            } else
            {
                Console.WriteLine($"{from} -> {to} | Step {move}");
            }
            GetStepsCount(desks - 1, from, aux, to);
        }
    }
}
