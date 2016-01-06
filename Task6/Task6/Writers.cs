using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6
{
    class Writer
    {
        public int Compare(Employee empl1, Employee empl2)
        {
            if (empl1.Sallary == empl2.Sallary)
            {
                return empl1.Name.CompareTo(empl2.Name);
            }
            else
            {
                return empl1.Sallary.CompareTo(empl2.Sallary);
            }
        }

        public void CreateWriter(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
        }


        public void WriteSortedList(string filePath, List<Employee> employees)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                employees.Sort(Compare);
                foreach (Employee empl in employees)
                {
                    writer.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.Sallary);
                }
            }
        }

        public void WriteFirstEmployees(string filePath, List<Employee> employees, int employeesQuantity)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                employees.Sort(Compare);
                foreach (Employee empl in employees.Take(employeesQuantity))
                {
                    writer.WriteLine(empl.Name);
                }
            }
        }

        public void WriteLastIds(string filePath, List<Employee> employees, int idQuantity)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                employees.Sort(Compare);
                foreach (Employee empl in employees.Skip(employees.Count() - idQuantity))
                {
                    writer.WriteLine(empl.Id);
                }
            }
        }   
    }
}
//TODO: EXCEPTION HANDLING (ADDING TO EXISTANT FILE)