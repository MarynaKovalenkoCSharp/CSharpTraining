using Task6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;

namespace Task6
{
    class EmployeeListCreator
    {
        List<Employee> employees = new List<Employee>();
        
        public List<Employee> AddEmployees(int numberOfFixedPayEmployees, int numberOfHourlyEmployees)
        {
            PersonNameGenerator random = new PersonNameGenerator();
            Random rand = new Random();
            for(int i = 1; i < numberOfFixedPayEmployees + 1 ; i++)
            {
                employees.Add(new FixedPayEmployee(random.GenerateRandomFirstName(),random.GenerateRandomLastName(), i, rand.Next(1000, 3000)));              
            }

            for(int i = 1; i < numberOfHourlyEmployees + 1 ; i++)
            {              
                employees.Add(new HourlyEmployee(random.GenerateRandomFirstName(), random.GenerateRandomLastName(), numberOfFixedPayEmployees + i, rand.Next(10, 30)));
            }

            return employees;
        }
    }
}
