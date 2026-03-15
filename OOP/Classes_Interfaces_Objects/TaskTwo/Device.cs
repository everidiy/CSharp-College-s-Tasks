using System;

namespace TaskTwo
{
    internal class Device : Rules
    {
        internal bool status;
        internal string deviceName;
        internal string type;

        public void GetInfo()
        {
            string isActive = status ? "Включено" : "Выключено";
            Console.Clear();
            Console.WriteLine($"\nВаше устройство - {type}: {deviceName}");
            Console.WriteLine($"Название устройства - {deviceName}");
            Console.WriteLine($"Тип устройства - {type}");
            Console.WriteLine($"Статус устройства - {isActive}\n");
        }
        public void GetOnOff()
        {
            Console.Clear();

            if (status)
            {
                status = false;
                Console.WriteLine($"Ваше устройство - {deviceName} - было выключено!");
            } else
            {
                status = true;
                Console.WriteLine($"Ваше устройство - {deviceName} - было включено!");
            }

            
        }
    }
}
