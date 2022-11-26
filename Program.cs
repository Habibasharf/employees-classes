using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7task3
{
    internal class Program
    {
        public static void GetEmployeeWithLongestArrayOfClint(Employee [] e)
        {
            for(int i = 0; i < e.Length; i++)
            {
                    if (e[0].ArrayOfClint.Length < e[i].ArrayOfClint.Length)
                    {
                        e[0] = e[i];
                   
                    }
                
            }
            e[0].ShowEmployeeDetails();
            Console.ReadKey();
        }
        #region Functions but not used


        public static Clints[] InsertClint(Clints[] _cl)
        {
            for (int i = 0; i < _cl.Length; i++)
            {
                _cl[i] = new Clints();
                Console.WriteLine($"Clint data [{i + 1}]");
                Console.Write($"\tEnter id for clint = ");
                _cl[i].ID = int.Parse(Console.ReadLine());
                Console.Write($"\tEnter name for clint: ");
                _cl[i].Name = Console.ReadLine();
                Console.Write($"\tEnter city name for clint: ");
                _cl[i].City = Console.ReadLine();
            }
            return _cl;
        }
        public static HREmployee[] InsertHr(HREmployee[] _hr)
        {
            for (int i = 0; i < _hr.Length; i++)
            {
                _hr[i] = new HREmployee();
                Console.WriteLine($"HRemployee data [{i + 1}]");
                Console.Write($"\tEnter id for hr employee = ");
                _hr[i].ID = int.Parse(Console.ReadLine());
                Console.Write($"\tEnter name for hr employee is: ");
                _hr[i].Name = Console.ReadLine();
                Console.Write($"\tEnter salary for hr employee = ");
                _hr[i].Salary = int.Parse(Console.ReadLine());
                Console.Write($"\tEnter number of clint array = ");
                int y = int.Parse(Console.ReadLine());
                Clints[] c = new Clints[y];
                _hr[i].ArrayOfClint = InsertClint(c);
            }
            return _hr;
        }
        public static PREmployee[] InsertPr(PREmployee[] _br)
        {
            for (int i = 0; i < _br.Length; i++)
            {
                _br[i] = new PREmployee();
                Console.WriteLine($"PRemployee data [{i + 1}]");
                Console.Write($"\tEnter id for pr employee = ");
                _br[i].ID = int.Parse(Console.ReadLine());
                Console.Write($"\tEnter name for pr employee is: ");
                _br[i].Name = Console.ReadLine();
                Console.Write($"\tEnter salary for pr employee = ");
                _br[i].Salary = int.Parse(Console.ReadLine());
                Console.Write($"\tEnter number of clint array = ");
                int y = int.Parse(Console.ReadLine());
                Clints[] c = new Clints[y];
                _br[i].ArrayOfClint = InsertClint(c);
            }
            return _br;
        }
        public static Employee[] EmpArray(HREmployee[] hr, PREmployee[] pr)
        {

            Employee[] emp = new Employee[hr.Length + pr.Length];
            for (int i = 0; i < hr.Length; i++)
            {
                emp[i] = hr[i];
            }
            int j = 0;
            for (int i = hr.Length; i < emp.Length; i++, j++)
            {
                emp[i] = pr[j];
            }


            return emp;
        }
        #endregion
        static void Main(string[] args)
        {
            #region try it only


            Console.Write($"\tenter number of hr array = ");
            int y = int.Parse(Console.ReadLine());
            HREmployee[] hr = new HREmployee[y];
            HREmployee[] hr1 = InsertHr(hr);
            Console.Write($"\tenter number of pr array = ");
            int x = int.Parse(Console.ReadLine());
            PREmployee[] pr = new PREmployee[x];
            PREmployee[] pr1 = InsertPr(pr);
            Employee[] emp1 = new Employee[hr1.Length + pr1.Length];
            emp1 = EmpArray(hr1, pr1);
            #endregion

            #region ...... only  for test


            //Employee[] emp = new Employee[]
            //{
            //    new HREmployee(){ID = 1,Name = "Ahmed" , Salary=500,
            //        ArrayOfClint=new Clints[]
            //        {
            //            new Clints(){ID=1,Name="Mohamed",City="Mansoura"},
            //            new Clints(){ID=2,Name="Adel",City="Alex"},
            //          } 
            //    },
            //     new HREmployee(){ID = 2,Name = "Habiba" , Salary=7000,
            //        ArrayOfClint=new Clints[]
            //        {
            //            new Clints(){ID=1,Name="Hany",City="Tanta"},
            //          }
            //    },
            //      new PREmployee(){ID = 1,Name = "Mazen" , Salary=5000,
            //        ArrayOfClint=new Clints[]
            //        {
            //            new Clints(){ID=1,Name="Mohamed",City="Mansoura"},
            //            new Clints(){ID=2,Name="Adel",City="Alex"},
            //             new Clints(){ID=3,Name="Fares",City="Alex"},
            //          }
            //    },
            //       new HREmployee(){ID = 2,Name = "Marwan" , Salary=6000,
            //        ArrayOfClint=new Clints[]
            //        {
            //            new Clints(){ID=1,Name="Mohamed",City="Mansoura"},
            //            new Clints(){ID=2,Name="Adel",City="Alex"},
            //            new Clints(){ID=3,Name="Yousef",City="Cairo"},
            //            new Clints(){ID=4,Name="Ali",City="Tanta"},
            //          }
            //    },

            //};
            #endregion

            Console.WriteLine("Employee with the longest array of client");
            GetEmployeeWithLongestArrayOfClint(emp1);

            HREmployee hrone = new HREmployee()
            {
                ID = 1,
                Name = "ali",
                Salary = 2000,
                
                ArrayOfClint = new Clints[]
                {
                    new Clints(){ID = 1, Name = "ahmed",City ="tanta"},
                    new Clints(){ID = 2, Name = "ali",City ="tanta"},
                    new Clints(){ID = 3, Name = "hamed",City ="tanta"},
                }
            };
            HREmployee hrtwo = new HREmployee()
            {
                ID = 2,
                Name = "ahmed",
                Salary = 4000,

                ArrayOfClint = new Clints[]
                {
                    new Clints(){ID = 1, Name = "ahmed",City ="tanta"},
                    new Clints(){ID = 2, Name = "ali",City ="tanta"},
                }
            };
            Console.WriteLine("the summetion of two HR employee");
            HREmployee hr3 = new HREmployee();
            hr3 = hrone + hrtwo;
            hr3.ShowEmployeeDetails();
            Console.WriteLine($"If hr one larger than hr two is : {hrone>hrtwo}");
            Console.WriteLine($"If hr one larger than or equal hr two is : {hrone >= hrtwo}");

        }
    }
}
