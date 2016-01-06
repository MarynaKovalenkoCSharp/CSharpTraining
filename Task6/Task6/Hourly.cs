using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name, string secondName, int id, int rate)
            : base(name, secondName, id, rate)
        {
        }

        public override double CalculateSallary()
        {
            double averageMonthSallary = Rate * 20.8 * 8;
            return averageMonthSallary;
        }
    }
}