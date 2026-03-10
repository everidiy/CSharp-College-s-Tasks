

using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            Console.WriteLine($" Массивы: \n");

            int[] K = FormArray(4);
            Console.Write($" K: {PrintArr(K)}\n");
            
            int[] M = FormArray(7);
            Console.Write($" M: {PrintArr(M)}\n");

            int[] C = FormArray(12);
            Console.Write($" C: {PrintArr(C)}\n");

            Console.WriteLine();

            Console.WriteLine($" N = (GetMax(K) * GetMax(M)) / (GetMin(K) * GetMin(C)) ");
            Console.WriteLine($" N = ({GetMax(K)} * {GetMax(M)}) / ({GetMin(K)} * {GetMin(C)}) ");
            int N = (GetMax(K) * GetMax(M)) / (GetMin(K) * GetMin(C));

            Console.WriteLine($" N = {N}");
        }

        static int[] FormArray(int length)
        {
            int[] arr = new int[length];
            for (int i = 0;  i < length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }

            return arr;
        }

        static string PrintArr(int[] arr)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                str += $" {arr[i]} ";
            }

            return str;
        }

        static int GetMax(int[] arr)
        {
            return arr.Max();
        }

        static int GetMin(int[] arr)
        {
            return arr.Min();
        }
    }
}
