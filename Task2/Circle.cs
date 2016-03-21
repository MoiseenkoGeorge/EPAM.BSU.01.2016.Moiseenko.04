using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Circle : IShape
    {
        private const double Pi = Math.PI;
        public double Diameter { get { return 2*Radius; } }
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetPerimeter() => 2*Pi* Radius;
        public double GetSquare() => Math.Pow(Radius, 2)*Pi;
    }
}
