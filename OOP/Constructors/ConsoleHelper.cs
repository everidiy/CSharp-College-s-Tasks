using System;
using System.Threading;

namespace Constructor
{
    internal class ConsoleHelper
    {
        public static void PrintCenteredColored(string name, string surname, int grade, double average, int passes)
        {
            string baseText = $"{name} | {surname} | {grade} | {average:F1} | {passes}";
            int totalWidth = Console.WindowWidth;
            int leftPadding = (totalWidth - baseText.Length) / 2;
            if (leftPadding < 0) leftPadding = 0;

            Console.Write(new string(' ', leftPadding));

            Console.Write($"{name} | {surname} | {grade} | ");

            if (average <= 3.49)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (average <= 4.49)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{average:F1}");
            Console.ResetColor();

            Console.Write(" | ");
            if (passes >= 15)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (passes >= 6 && passes <= 10)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{passes}");
            Console.ResetColor();

            Console.WriteLine();
        }

        public static void PrintCentered(string text)
        {
            int leftPadding = (Console.WindowWidth - text.Length) / 2;

            if (leftPadding < 0)
                leftPadding = 0;

            Console.WriteLine(new string(' ', leftPadding) + text);
        }

        public static string ReadCentered(string prompt)
        {
            int width = Console.WindowWidth;
            int promptLength = prompt.Length;

            int left = (width - promptLength) / 2;
            if (left < 0) left = 0;

            Console.SetCursorPosition(left, Console.CursorTop);
            Console.Write(prompt);

            Console.SetCursorPosition(left + promptLength, Console.CursorTop);

            return Console.ReadLine();
        }

        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (!int.TryParse(input, out int value))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Введите целое число.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.Clear();
                    PrintCentered($"Ошибка! Допустимо: {min} - {max}");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                return value;
            }
        }

        public static double ReadDouble(string prompt, double min, double max)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (!double.TryParse(input, out double value))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Введите число.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.Clear();
                    PrintCentered($"Ошибка! Допустимо: {min} - {max}");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                return value;
            }
        }

        public static string ReadString(string prompt)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Пустая строка.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                if (double.TryParse(input, out double _))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Введите текст, а не число.");
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
                    PrintCentered("Ошибка! В тексте недопустимо число.");
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
                    PrintCentered("Ошибка! В тексте допустимы только русские буквы.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                return input;
            }
        }
    }
}
