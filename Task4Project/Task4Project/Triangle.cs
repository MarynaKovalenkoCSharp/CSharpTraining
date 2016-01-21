using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Triangle : Figure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double x, double y, double a, double b, double c)
            : base(x, y)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
        }

        public override double CalculateArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            double area = Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            this.Area = area;
            return Math.Round(area, 2);
        }
    }
}
