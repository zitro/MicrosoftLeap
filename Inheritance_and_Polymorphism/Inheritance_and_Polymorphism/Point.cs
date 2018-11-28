using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Polymorphism
{
    public class Point
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}
