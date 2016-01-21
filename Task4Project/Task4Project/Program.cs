using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle(0, 0, 3, 4, 2);
            Rectangle newRectangle = new Rectangle(0, 0, 3, 5.5);
            newTriangle.Equals(newRectangle);
            Console.WriteLine(newTriangle);
            Console.ReadKey();
        }
    }
}
