using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a,double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double GetPerimeter() => A + B + C;

        public double GetSquare()
        {
            double p = GetPerimeter()/2;
            return Math.Pow(p*(p - A)*(p - B)*(p - C), 2);
        }
    }
}
