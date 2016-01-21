using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Rectangle : Figure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Rectangle(double x, double y, double a, double b)
            : base(x, y)
        {
            FirstSide = a;
            SecondSide = b;
        }

        public override double CalculateArea()
        {
            double area = FirstSide * SecondSide;
            return Math.Round(area, 2);
        }
    }
}
