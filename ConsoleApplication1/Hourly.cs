using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HourlyEmployee : Employee
    {
        
        public override double calculateSallary(double rate)
        {
            double averageMonthSallary = rate * 20.8 * 8;
            return averageMonthSallary;
        }
    }
}
