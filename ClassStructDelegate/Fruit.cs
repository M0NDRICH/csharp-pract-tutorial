using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructDelegate
{
    public struct Fruit 
    {
        public Fruit(string name, string color) 
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; } // = "Red"; Initial Value same with class
    }
}
