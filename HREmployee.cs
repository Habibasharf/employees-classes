using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7task3
{
    internal class HREmployee:Employee
    {
        public override void ShowEmployeeDetails()
        {
            
            Console.WriteLine($"ID --> {ID} , Name --> {Name} , Salary --> {Salary} , Clints Data --> ");
            for(int i =0; i < ArrayOfClint.Length; i++)
            {
                ArrayOfClint[i].ShowData();
            }
        }
        #region concate clints
        public Clints[] concatClint(Clints[] c1,Clints[] c2)
        {
            Clints[] c3 = new Clints[c1.Length + c2.Length];
            for (int i = 0; i < c1.Length; i++)
            {
               c3[i] = c1[i];
            }
            int j = 0;
            for (int i = c1.Length; i < c3.Length; i++,j++)
            {
                c3[i] = c2[j];
            }
            return c3;
        }
    
        #endregion
        public static HREmployee operator +(HREmployee _d1, HREmployee _d2)
        {
            HREmployee hr = new HREmployee();
            // stdone+stdtwo
            HREmployee result = new HREmployee() { ID = _d1.ID + _d2.ID, Name = _d1.Name + _d2.Name, Salary = _d1.Salary + _d2.Salary, ArrayOfClint =  hr.concatClint(_d1.ArrayOfClint,_d2.ArrayOfClint) };

            return result;
        
            
        }
        public static bool operator >(HREmployee _D1, HREmployee _D2)
        {
            return _D1.ID > _D2.ID && _D1.Name.Length > _D2.Name.Length && _D1.Salary > _D2.Salary && _D1.ArrayOfClint.Length > _D2.ArrayOfClint.Length;
        }
        public static bool operator <(HREmployee _D1, HREmployee _D2)
        {
            return !(_D1 > _D2);

        }

        public static bool operator >=(HREmployee _D1, HREmployee _D2)
        {
            return _D1.ID > _D2.ID && _D1.Name.Length > _D2.Name.Length && _D1.Salary > _D2.Salary && _D1.ArrayOfClint.Length > _D2.ArrayOfClint.Length;
        }
        public static bool operator <=(HREmployee _D1, HREmployee _D2)
        {
            return !(_D1 >= _D2);

        }
        //public static HREmployee operator +(HREmployee _d1, HREmployee _d2)
        //{
        //    // stdone+stdtwo
        //   // HREmployee result = new HREmployee() { ID = _d1.ID + _d2.ID, Name = _d1.Name + _d2.Name, Salary = _d1.Salary + _d2.Salary , ArrayOfClint= _d1.ArrayOfClint+_d2.ArrayOfClint };
        //    return result;
        //}
    }
}
