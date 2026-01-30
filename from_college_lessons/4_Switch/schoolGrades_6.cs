using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task: Get a verbal description of school grades - RU version\n");
            Console.Write(" Enter a grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case 1:
                    Console.WriteLine(" Your grade - 1 - BAD");
                    break;
                case 2:
                    Console.WriteLine(" Your grade - 2 - NOT SATISFACTORILY");
                    break;
                case 3:
                    Console.WriteLine(" Your grade - 3 - SATISFACTORILY");
                    break;
                case 4:
                    Console.WriteLine(" Your grade - 4 - GOOD");
                    break;
                case 5:
                    Console.WriteLine(" Your grade - 5 - GREAT");
                    break;
                default:
                    Console.WriteLine(" The number specified is incorrect");
                    break;
            }
        }
    }
}
