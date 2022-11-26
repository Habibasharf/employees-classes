using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7task3
{
    internal class Clints
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public void ShowData()
        {
            Console.WriteLine($"Clint Data is : ID --> {ID} , Name --> {Name} , City --> {City}");
        }
    }
}
