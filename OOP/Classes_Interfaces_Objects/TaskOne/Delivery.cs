using System;

namespace TaskOne
{
    internal class Delivery : Rules
    {
        internal string type;
        internal int cost;
        internal bool isAccepted;

        public void CountCost(int money)
        {
            Console.Clear();
            
            if (isAccepted)
            {
                Console.WriteLine($"Стоимость вашей доставки: {cost}");
                Console.WriteLine($"Тип доставки - {type}");
            }
            else
            {
                Console.WriteLine("Доставка не оформлена! ");
            }
        }

        public void GetDelivery()
        {
            Console.Clear();

            if (isAccepted)
            {
                Console.WriteLine("Хотите отменить доставку? (да/нет) ");
                string solution = Console.ReadLine();

                if (solution == "да")
                {
                    isAccepted = false;
                    Console.Clear();
                    Console.WriteLine("Ваша доставка отменена!");
                }
            } 
            else
            {
                Console.WriteLine("Хотите оформить доставку? (да/нет) ");
                string input = Console.ReadLine();

                if (input == "да")
                {
                    isAccepted = true;
                    Console.Clear();
                    Console.WriteLine("Ваша доставка оформлена!");
                }
            }
        }

        public void GetInfo()
        {
            Console.Clear();

            if (isAccepted)
            {
                Console.WriteLine("Доставщик едет к вам :) ");
                Console.WriteLine($"Тип доставки - {type}");
            }
            else
            {
                Console.WriteLine("Доставка не оформлена! ");
            }
        }
    }
}
