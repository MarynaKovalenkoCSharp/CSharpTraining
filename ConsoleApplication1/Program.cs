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
            List<FixedPayEmployee> employees = new List<FixedPayEmployee>();
            FixedPayEmployee empl = new FixedPayEmployee();
            empl.Name = "Ivan";
            empl.SecondName = "Ivanov";
            empl.id = 1;
            empl.rate = 20.4;
            employees.Add(empl);

            Console.WriteLine(employees);
            Console.ReadKey();
        }

    }

}

