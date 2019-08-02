using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class employeedisplay:EmployeeDetails
    {
        public static void empdisp()
        {
            EmployeeDetails del = new EmployeeDetails();
            
            foreach(var emp in del.listemp)
            {
                Console.WriteLine("first name is {0} Last Name is {1}, Age is {2}, Country {3},  City {4}", emp.firstname, emp.lastname, emp.Age, emp.Country, emp.city);
            }
            Console.WriteLine("Total employees in the offices are {0}", del.listemp.Count());
            Console.ReadLine();
            //foreach(var emp1 in del.e)
            //{
            //    Console.WriteLine("");
            //}
        }
    }
}
