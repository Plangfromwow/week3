using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassSeperateFile
{

    // replace internal with public
    internal class Rectangle
    {
        public static int count = 0;
        public string name;
        public double height;
        public double length;

        public Rectangle(string _name, double _height, double _length)
        {
            count++;
            name = _name;
            height = _height;
            length = _length;
        }



        public override string ToString()
        {
            return $"{name}: Length {length} Height {height} Area: {length * height} Perimeter: {2 * length + 2 * height}";
        }

    }
}
