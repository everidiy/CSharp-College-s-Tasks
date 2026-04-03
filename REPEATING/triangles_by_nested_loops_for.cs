using System;

namespace repeating
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
