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

        static void Main1()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new FixedPayEmployee("Ivan", "Ivanov", 1, 2890));

            employees.Add(new FixedPayEmployee("Andrey", "Andreev", 2, 3720));

            employees.Add(new FixedPayEmployee("Fedor", "Fedorov", 3, 1445));

            employees.Add(new FixedPayEmployee("Yuri", "Yuriev", 4, 2354));

            employees.Add(new FixedPayEmployee("Anton", "Antonov", 5, 6456));

            employees.Add(new HourlyEmployee("Petr", "Petrov", 6, 20));

            employees.Add(new HourlyEmployee("Oleg", "Olegov", 7, 15));

            employees.Add(new HourlyEmployee("Artem", "Artemov", 8, 17));

            employees.Add(new HourlyEmployee("Sergey", "Sergeev", 9, 19));


            StreamWriter writer1 = new StreamWriter(@"D:\employeesWithSallary.txt");
            foreach (Employee empl in employees)
            {
                empl.Sallary = empl.calculateSallary();
                writer1.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.SecondName + "\t" + empl.Rate + "\t" + empl.Sallary);
            }
            writer1.Close();

            
            //Task A
            StreamWriter writer2 = new StreamWriter(@"D:\sortedBySallary.txt");
            employees.Sort(Compare);
            foreach (Employee empl in employees)
                { 
                writer2.WriteLine(empl.Id + "\t" + empl.Name + "\t" + empl.Sallary);
                }
            writer2.Close();

            //Task B
            List<string> FirstFiveEmployees = new List<string>();
            StreamReader reader1 = new StreamReader(@"D:\sortedBySallary.txt");
            string line;
            while ((line = reader1.ReadLine()) != null)
            {
                FirstFiveEmployees.Add(line);
            }
            /* {
                writer3.WriteLine(empl.Name);
                StreamWriter writer3 = new StreamWriter(@"D:\firstFiveNames.txt");
            foreach (Employee empl in employees.Take(5))
                {
                writer3.WriteLine(empl.Name);
                }
            writer3.Close();
            */
            //Task C
            StreamWriter writer4 = new StreamWriter(@"D:\lastThreeIndices.txt");
            foreach (Employee empl in employees.Skip(employees.Count() - 3))
            {
                writer4.WriteLine(empl.Id);
            }
            writer4.Close();
                        
        }
    }
}