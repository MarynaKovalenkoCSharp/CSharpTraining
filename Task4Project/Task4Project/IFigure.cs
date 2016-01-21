using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    interface IFigure
    {
        string ToString();
        bool Equals(object @object);
        double CalculateArea();

    }
}
