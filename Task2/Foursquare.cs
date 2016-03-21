using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Foursquare : Rectangle
    {
        public Foursquare(double a) : base(a, a)
        {
            A = a;
        }

        public override double GetPerimeter() => A*4;

        public override double GetSquare() => A*A;
    }
}
