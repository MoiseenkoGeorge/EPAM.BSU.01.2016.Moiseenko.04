using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Rectangle : IShape
    {
        public double A { get; protected set; }
        public double B { get; private set; }

        public Rectangle(double a,double b)
        {
            A = a;
            B = b;
        }

        public virtual double GetPerimeter() => 2*(A + B);

        public virtual double GetSquare() => A*B;
    }
}
