using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14_Basic_Classes
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

        public static string ReadString(string prompt)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Текст не может быть пустым!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                if (double.TryParse(input, out double _))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Текст не может иметь число!");
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
                    PrintCentered("Ошибка! Текст не может иметь текст с числом!");
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
                    c == 'Ё' || c == 'ё') || 
                    (c == '-'))
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

        public static DateTime ReadBirthday(string prompt)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Текст не может быть пустым!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                bool hasInvalidChar = false;
                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    if (
                    !((c >= '0' && c <= '9') ||
                    (c == '.')))
                    {
                        hasInvalidChar = true;
                        break;
                    }
                }

                if (hasInvalidChar)
                {
                    Console.Clear();
                    PrintCentered("Ошибка! В тексте допустимы только спец-символы!");
                    PrintCentered(". 0-9");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                if (DateTime.TryParseExact(
                    input,
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date))
                {
                    return date;
                }
                else
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Неправильно написан шаблон!");
                    PrintCentered("00.00.0000");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

            }
        }

        public static string ReadAddress(string prompt)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Текст не может быть пустым!");
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
                    (c >= '0' && c <= '9') ||
                    (c == 'Ё' || c == 'ё') ||
                    (c == '-' || c == ',' ||
                    c == '.' || c == ' ')))
                    {
                        hasInvalidChar = true;
                        break;
                    }
                }

                if (hasInvalidChar)
                {
                    Console.Clear();
                    PrintCentered("Ошибка! В тексте допустимы только русские буквы и спец-символы!");
                    PrintCentered(". , - ' ' А-Я а-я 0-9");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                return input;
            }
        }

        public static string ReadPhoneNumber(string prompt)
        {
            while (true)
            {
                string input = ReadCentered(prompt);

                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Текст не может быть пустым!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                bool hasInvalidChar = false;
                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    if (
                    !((c >= '0' && c <= '9') ||
                    (c == '-' || c == '(' ||
                    c == ')' || c == ' ' || c == '+')))
                    {
                        hasInvalidChar = true;
                        break;
                    }
                }

                if (hasInvalidChar)
                {
                    Console.Clear();
                    PrintCentered("Ошибка! В тексте допустимы только спец-символы!");
                    PrintCentered("- + ( ) ' ' 0-9");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
                
                if (input.Length < 11)
                {
                    Console.Clear();
                    PrintCentered("Ошибка! Телефон слишком короткий");
                    PrintCentered("11 цифр");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

                return input;
            }
        }
    }
}
