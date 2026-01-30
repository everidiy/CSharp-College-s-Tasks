using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Enter an array consisting of 20 integer elements.\n Determine whether there are more elements—even or odd in value.");
            Console.Write(" Enter array's size: ");

            int size = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] arr = new int[size];

            Console.Write("\n Your array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
                Console.Write($"{arr[i]} ");
            }

            int even = 0;
            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"\n Even: {even}; Odd: {odd};");
            
        }
    }
}
