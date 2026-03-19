using System;

namespace Method_parameters_2
{
    internal class Program
    {
        static void Main()
        {
            int num = 153;
            Console.WriteLine($"Число {num}");

            Console.WriteLine($"\nСледовательно, число {num} по методу IsArmstrong -> {IsArmstrong(num)}");
        }

        static bool IsArmstrong(int n)
        {
            int temp = n;
            int result = 0;

            string strlength = temp.ToString();
            int numLength = strlength.Length;
            int[] digits = new int[numLength];

            Console.Write("Массив из числа: ");
            for (int i = 0; i < strlength.Length; i++)
            {
                digits[i] = strlength[i] - '0';
                Console.Write(digits[i] + " ");
            }

            for (int i = 0; i < digits.Length; i++)
            {
                result += (int)Math.Pow(digits[i], numLength);
            }
            Console.WriteLine($"\nЧисло - {temp} | Оно по Армстронгу - {result}");

            return result == n;
        }
    }
}
