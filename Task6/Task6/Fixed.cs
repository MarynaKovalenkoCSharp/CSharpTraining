using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class FixedPayEmployee : Employee
    {
        public FixedPayEmployee(string name, string secondName, int id, int rate)
            : base(name, secondName, id, rate)
        {
        }

        public override double CalculateSallary()
        {
            double averageMonthSallary = Rate;
            return averageMonthSallary;
        }
    }
}