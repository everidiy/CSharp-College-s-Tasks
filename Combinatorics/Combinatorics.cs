using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace MathProgramFromMethod
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Приветствую вас в калькуляторе комбинаторики!");
            Console.WriteLine("Выберите способ вычисления: (1-4)\n");
            int step = Convert.ToInt32(Console.ReadLine());

            switch (step) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: Факториал!\n");
                    Console.WriteLine("Введите ваше число...");

                    int n = Convert.ToInt32(Console.ReadLine());
                    long resultF = Factorial(n);
                    Console.WriteLine($"Результат: {resultF}");
                break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: Сочетание!\n");
                    Console.WriteLine("Ввод происходит сверху вниз, иначе 0!\n");

                    Console.WriteLine("Введите ваше число #1...");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите ваше число #2...");
                    int k = Convert.ToInt32(Console.ReadLine());

                    long resultC = Combinations(a, k);
                    Console.WriteLine($"Результат: {resultC}");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: Размещение!\n");
                    Console.WriteLine("Ввод происходит сверху вниз, иначе 0!\n");

                    Console.WriteLine("Введите ваше число #1...");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите ваше число #2...");
                    int v = Convert.ToInt32(Console.ReadLine());

                    long resultP = Placements(b, v);
                    Console.WriteLine($"Результат: {resultP}");
                break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Вы выбрали: Перестановка С Повторениями!\n");

                    Console.WriteLine("Сколько разных типов элементов?");
                    Console.WriteLine("Например, в слове МАМА - 2 типа\n");
                    int t = Convert.ToInt32(Console.ReadLine());

                    int[] counts = new int[t];

                    for (int i = 0; i < t; i++)
                    {
                        Console.WriteLine($"Введите количество элементов типа {i + 1}:");
                        counts[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    long resultPR = PermutationsWithRepetitions(counts);
                    Console.WriteLine($"Результат: {resultPR}");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Упс! Вы выбрали не тот пункт! Попробуйте еще раз!\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Main();
                break;
            }

        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1) {
                return 1;
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i; 
            }

            return result;
        }

        static long Combinations(int n, int k)
        {
            if (n < 0 || k < 0)
                return 0;

            if (k > n)
                return 0;

            long first = Factorial(n);
            long second = Factorial(k) * Factorial(n - k);

            long result = first / second;
            return result;
        }

        static long Placements(int n, int k)
        {
            if (n < 0 || k < 0)
                return 0;

            if (k > n)
                return 0;

            long first = Factorial(n);
            long second = Factorial(n - k);

            long result = first / second;
            return result;
        }

        static long PermutationsWithRepetitions(params int[] counts)
        {
            int total = 0;
            foreach (int count in counts)
            {
                if (count < 0) 
                    return 0;
                total += count;
            }

            long numerator = Factorial(total);

            long denominator = 1;
            foreach (int count in counts)
            {
                denominator *= Factorial(count);
            }

            return numerator / denominator;
        }
    }
}
