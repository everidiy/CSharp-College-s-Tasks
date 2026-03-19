using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            double grade1 = CalculateFinalGrade(5, 4, 3, 5, 4);
            Console.WriteLine(grade1);
        }

        static double CalculateFinalGrade(params int[] nums)
        {
            List<int> result = nums.ToList();
            double total = 0;

            result.Sort();

            result.RemoveAt(0);
            result.RemoveAt(result.Count - 1);

            for (int i = 0; i < result.Count; i++)
            {
                total += result[i];
            }

            total /= result.Count;

            return total;
        }
    }
}
