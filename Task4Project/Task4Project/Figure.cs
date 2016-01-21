using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Figure : IFigure
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double Area { get; set; }

        public Figure()
        {

        }

        public Figure(double x, double y)
        {
            CoordX = x;
            CoordY = y;
        }

        public override string ToString()
        {
            return "Information about figure: \nName\t" + this.GetType().Name + "\nArea\t" + this.CalculateArea();
        }

        public override bool Equals(Figure obj)
        {
            bool typeComparisonResult = (this.GetType() == obj.GetType()) ? true : false;
            bool coordinatesComparisonResult = typeComparisonResult ? (this.CoordX == obj.CoordX) && (this.CoordY == obj.CoordY) : false;
            bool areaComparisonResult = coordinatesComparisonResult ? (this.Area == obj.Area) : false;
            bool finalResult = areaComparisonResult ? true : false;
            return finalResult;
        }

        public abstract double CalculateArea();

    }
}
