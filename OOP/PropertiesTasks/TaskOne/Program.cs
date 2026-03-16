using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskOneProperties
{
    internal class Program
    {
        static List<Human> list = new List<Human>();    

        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Do you want to see info about people? (yes/no)");
            string answer = Console.ReadLine();
            Console.WriteLine();

            switch (answer.ToLower())
            {
                case "yes":
                    GetData();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong choise!");
                    Thread.Sleep(1000);
                    Main();
                    break;
            }
        }

        static void GetData()
        {
            Console.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {list[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Add new person - (1)");
            Console.WriteLine("Exit - (2)\n");

            Console.Write("Your choise => ");
            int.TryParse(Console.ReadLine(), out int value);

            switch (value)
            {
                case 1:
                    AddNewPerson();
                    Console.Write("\nEnter different button to go to back :) ");
                    Console.ReadKey();
                    GetData();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong choise!");
                    Thread.Sleep(1000);
                    GetData();
                    break;
            }
        }
        
        static void AddNewPerson()
        {
            Console.Clear();

            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int ageInpit);
            Console.WriteLine();

            Human person = new Human();
            person.Name = nameInput;
            person.Age = ageInpit;

            list.Add(person);

            person.GetHumanInfo();
        }
    }
}
