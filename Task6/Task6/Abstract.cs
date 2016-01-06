using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public abstract class Employee
    {

        public string Name { get; set; }

        public string SecondName { get; set; }

        public int Id { get; set; }

        public double Rate { get; set; }

        public double Sallary
        {
            get
            {
                return CalculateSallary();
            }
            set;
        }

        public Employee(string name, string secondName, int id, int rate)
        {
            Name = name;
            SecondName = secondName;
            Id = id;
            Rate = rate;
        }

        public abstract double CalculateSallary();

    }
}