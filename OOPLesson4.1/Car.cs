using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson4._1
{
    internal class Car:Garage
    {
        public string Color { get; set; }

        public Car(string color,string type)
        :base(type)
        {
            Color = color;
        }


        public string Print()
        {
            return base.Print() + Color;
        }
    }
}
