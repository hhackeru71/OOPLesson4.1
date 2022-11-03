using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson4._1
{
    internal class Garage
    {
        public string Type { get; set; }

        public Garage(string type)
        {
            Type = type; 
        }

        public string Print()
        {
            return Type;
        }

    }
}
