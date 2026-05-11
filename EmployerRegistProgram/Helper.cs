using System;

namespace Utils
{
    public class Helper
    {
        public static void Error(string message)
        {
            Console.Clear();
            Console.WriteLine($"\nОшибка! {message}");
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить..");
            Console.ReadKey();
        }

        public static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(prompt);
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
                    Console.WriteLine($"Ошибка! Допустимо: {min} - {max}");
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
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Пустая строка.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                if (double.TryParse(input, out double _))
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Введите текст, а не число.");
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

        public static string GetAgeWord(int age)
        {
            if (age < 18 || age > 65)
                return "лет";

            int lastDigit = age % 10;
            int lastTwoDigits = age % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
                return "лет";

            if (lastDigit == 1)
                return "год";

            if (lastDigit >= 2 && lastDigit <= 4)
                return "года";

            return "лет";
        }
    }
}