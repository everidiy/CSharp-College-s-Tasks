using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOneProperties
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetHumanInfo()
        {
            Console.WriteLine($"Name: {Name} Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}
