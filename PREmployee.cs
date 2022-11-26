using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7task3
{
    internal class PREmployee:Employee
    {
        public override void ShowEmployeeDetails()
        {
            
            Console.WriteLine($"ID --> {ID} , Name --> {Name} , Salary --> {Salary} , Clints Data --> ");
            for (int i = 0; i < ArrayOfClint.Length; i++)
            {
                ArrayOfClint[i].ShowData();
            }
        }
    }
}
