using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double r)
            : base(x, y)
        {
            Radius = r;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return Math.Round(area, 2);
        }
    }
}
