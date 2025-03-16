using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp16
{
    internal class Point
    {
        private double x, y;

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public Point(){ }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine($"x = {x}\t y = {Y}");
        }
    }
}
