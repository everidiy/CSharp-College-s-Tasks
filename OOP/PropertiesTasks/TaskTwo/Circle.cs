using System;

namespace TaskTwoProperties
{
    internal class Circle
    {
        //поле класса
        private double _radius;

        //Главное свойство (с логикой!)
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("\nРадиус должен быть больше нуля\n");

                _radius = value;
            }
        }

        //конструктор
        public Circle(double radius)
        {
            Radius = radius; // используем свойство (с проверкой)
        }

        //Вычисляемые свойства
        public double Area => Math.PI * Radius * Radius;
        public double CircleLength => 2 * Math.PI * Radius;

    }
}
