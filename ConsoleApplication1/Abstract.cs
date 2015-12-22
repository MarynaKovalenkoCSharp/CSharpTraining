using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Employee
    {

        public string Name { get; set; }

        public string SecondName { get; set; }

        public int Id { get; set; }

        public double Rate { get; set; }

        public double Sallary { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string secondName, int id, double rate)
        {
            Name = name;
            SecondName = secondName;
            Id = id;
            Rate = rate;
        }

        public abstract double calculateSallary();

    }
}