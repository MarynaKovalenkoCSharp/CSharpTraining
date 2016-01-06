using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            EmployeeListCreator newList = new EmployeeListCreator();
            List<Employee> list = newList.AddEmployees(6, 5);

            ListHandler newHandler = new ListHandler();
            newHandler.CalculateSallary(list);

            Writer newWriter = new Writer();
            newWriter.WriteSortedList(@"D:\sortedBySallary.txt", list);
            newWriter.WriteFirstEmployees(@"D:\firstFiveEmployees.txt", list, 5);
            newWriter.WriteLastIds(@"D:\lastThreeIds.txt", list, 3);

        }
    }
}

// DATATABLE!