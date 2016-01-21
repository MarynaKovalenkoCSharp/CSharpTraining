using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6
{
    public class MyWriter : StreamWriter
    {
        public MyWriter(string filePath)
            : base(filePath)
        {

        }

        public MyWriter(string filePath, bool appending)
            : base(filePath, appending)
        {
            if (appending == true)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(filePath, appending);
                }
                catch (IOException exception)
                {
                    this.Close();
                    throw new IOException("File can't be written: " + exception.GetType().Name);
                }
            }
        }

        public void WriteData(List<Employee> employees, bool shuoldSort = true)
        {
            employees.Sort(Employee.Compare);
            employees.Reverse();
            foreach (Employee empl in employees)
            {
                this.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.Sallary);
            }
        }

        public void WriteData(List<Employee> employees, int employeesQuantity)
        {
            employees.Sort(Employee.Compare);
            foreach (Employee empl in employees.Take(employeesQuantity))
            {
                this.WriteLine(empl.Name);
            }
        }


        public void WriteData(List<Employee> employees)
        {
            employees.Sort(Employee.Compare);
            foreach (Employee empl in employees)
            {
                this.WriteLine(empl.Id);
            }
        }

    }
}