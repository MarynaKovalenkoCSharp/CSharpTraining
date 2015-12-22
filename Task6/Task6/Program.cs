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
        static int Compare(Employee empl1, Employee empl2)
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

        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new FixedPayEmployee("Ivan", "Ivanov", 1, 2890));

            employees.Add(new FixedPayEmployee("Andrey", "Andreev", 2, 3720));

            employees.Add(new FixedPayEmployee("Aleksey", "Alekseev", 3, 1445));

            employees.Add(new FixedPayEmployee("Mikhail", "Mikhailov", 4, 2354));

            employees.Add(new FixedPayEmployee("Anton", "Antonov", 5, 6456));

            employees.Add(new HourlyEmployee("Petr", "Petrov", 6, 20));

            employees.Add(new HourlyEmployee("Oleg", "Olegov", 7, 15));

            employees.Add(new HourlyEmployee("Artem", "Artemov", 8, 17));

            employees.Add(new HourlyEmployee("Sergey", "Sergeev", 9, 19));


            StreamWriter writer = new StreamWriter(@"D:\databaseInp1.txt");
            foreach (Employee empl in employees)
            {
                double calculatedSallary = empl.calculateSallary();
                empl.Sallary = calculatedSallary;
                writer.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.SecondName + "\t" + empl.Rate + "\t" + empl.Sallary);
            }
            writer.Close();

            employees.Sort(Compare);

            StreamWriter writer2 = new StreamWriter(@"D:\databaseInp2.txt");
            foreach (Employee empl in employees)
            {
                double calculatedSallary = empl.calculateSallary();
                empl.Sallary = calculatedSallary;
                writer2.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.Sallary);
            }
            writer2.Close();


            StreamWriter writer3 = new StreamWriter(@"D:\databaseInp3.txt");
            for (int i = 0; i == 5; i++ )
            {
                employees writer3.WriteLine(empl.Name);
            }
            writer3.Close();
            /* 
            foreach (Employee empl in employees)
            {
                empl.
            }
            List<string> databaseOut = new List<string>();
            StreamReader reader = new StreamReader("databaseOut.txt");
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    databaseOut.Add(line);
            }
            {
            
                // sort by sallary(desc)

                // print first 5 names
                Console.WriteLine(databaseOut);
                // print last 3 ids
                Console.WriteLine(databaseOut);
                // incorrect file format
           
            }
             */
        }
    }
}
    
