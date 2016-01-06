using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ListHandler
    {
        public List<Employee> CalculateSallary(List<Employee> employees)
        {
            foreach (Employee empl in employees)
            {
                Console.WriteLine("{0} {1}", empl.Name, empl.Sallary);
            }
            Console.ReadKey();
            return employees;
        }

        
    }
}
