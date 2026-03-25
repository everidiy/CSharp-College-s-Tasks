using System;
using System.Threading;

namespace TaskOneProperties
{
    internal class ConsoleHelper
    {
        public static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Пустая строка.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                bool hasDigit = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        hasDigit = true;
                        break;
                    }
                }

                if (hasDigit)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! В тексте недопустимо число.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                bool hasInvalidChar = false;
                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    if (
                    !((c >= 'А' && c <= 'Я') ||
                    (c >= 'а' && c <= 'я') ||
                    c == 'Ё' || c == 'ё' || c == '-'))
                    {
                        hasInvalidChar = true;
                        break;
                    }
                }

                if (hasInvalidChar)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! В тексте допустимы только русские буквы.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                return input;
            }
        }

        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int value))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Введите целое число.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.Clear();
                    Console.WriteLine($"Ошибка! Допустимо: {1} - {100}");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                return value;
            }
        }
    }
}
