using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FixedPayEmployee : Employee
    {

        public FixedPayEmployee(string name, string secondName, int id, double rate)
            : base(name, secondName, id, rate)
        {
        }
         public override double calculateSallary()
        {
            double averageMonthSallary = Rate;
            return averageMonthSallary;
        }
    }

}