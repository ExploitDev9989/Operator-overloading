using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public static double operator +(Circle c1, Circle c2)
        {
            return c1.Area() + c2.Area();
        }
        public static double operator -(Circle c1, Circle c2)
        {
            return Math.Abs(c1.Area() - c2.Area());
        }
    }
}

