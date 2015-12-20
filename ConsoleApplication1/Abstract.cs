using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract public class Employee
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string SecondName
        { 
            get
            {
                return SecondName;
            }
            set
            {
                SecondName = value;
            }
        }
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    
        public double rate
        {
        get
            {
                return rate;
            }
        set
            {
                rate = value;
            }
        }

        public abstract double calculateSallary(double rate);

        

    }
}
