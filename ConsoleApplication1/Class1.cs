using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program1
    {

        static DataTable GetTable()
        {
            DataTable myTable = new DataTable();
            myTable.Columns.Add("Id", typeof(int));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("SecondName", typeof(string));
            myTable.Columns.Add("Rate", typeof(double));
            myTable.Columns.Add("Sallary", typeof(double));

            myTable.Rows.Add(1, "Ivan", "Ivanov", 2890, 0);
            myTable.Rows.Add(2, "Andrey", "Andreev", 3720, 0);
            myTable.Rows.Add(3, "Fedor", "Fedorov", 1445, 0);
            myTable.Rows.Add(4, "Yuri", "Yuriev", 2354, 0);
            myTable.Rows.Add(5, "Anton", "Antonov", 6456, 0);
            myTable.Rows.Add(6, "Petr", "Petrov", 20, 0);
            myTable.Rows.Add(7, "Oleg", "Olegov", 15, 0);
            myTable.Rows.Add(8, "Artem", "Artemov", 17, 0);
            myTable.Rows.Add(9, "Sergey", "Sergeev", 19, 0);

            return myTable;
        }

        static void Main()
        {
            DataTable mytable = GetTable();
            //Console.WriteLine(mytable.Rows[0]);
            //Console.ReadKey();
          
            
        }

        
    }
}
