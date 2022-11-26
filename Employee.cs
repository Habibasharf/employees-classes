using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7task3
{
    abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Clints[] ArrayOfClint { get; set; }
        public abstract void ShowEmployeeDetails();
       

    }
}
