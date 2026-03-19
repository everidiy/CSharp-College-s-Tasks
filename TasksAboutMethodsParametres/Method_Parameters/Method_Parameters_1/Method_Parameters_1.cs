using System;

namespace TasksAboutMethodsParametres
{
    internal class Program
    {
        static void Main()
        {
            int num = 11;
            PrintDivisors(num);

            num = 25;
            PrintDivisors(num);

            Console.WriteLine($"\nЗначение числа переменной: {num}");
        }

        static void PrintDivisors(int n)
        {
            Console.WriteLine($"Делители числа {n}:");
            bool hasDivisors = false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i +  " ");
                    hasDivisors = true;
                }
            }

            if (!hasDivisors)
            {
                Console.WriteLine($"Делителей числа {n} кроме самого числа не существует");
            }
            Console.WriteLine();
        }
    }
}
