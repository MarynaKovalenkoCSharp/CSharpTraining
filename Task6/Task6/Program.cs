using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            EmployeeListCreator newList = new EmployeeListCreator();
            List<Employee> list = newList.AddEmployees(6, 5);

            ListHandler newHandler = new ListHandler();
            newHandler.CalculateSallary(list);

            MyWriter newWriter = new MyWriter(@"D:\Employees.txt");
            newWriter.WriteData(list);
            newWriter.WriteData(list.Skip(list.Count() - 3));
            newWriter.Close();
        }
    }
}

// DATATABLE!