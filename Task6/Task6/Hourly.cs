using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name, string secondName, int id, double rate) : base(name, secondName, id, rate)
        {            
        }

         public override double calculateSallary()
        {
            double averageMonthSallary = Rate * 20.8 * 8;
            return averageMonthSallary;
        }
    }
}