using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    public class Employee
    {
        public string firstname;
        public string lastname;
        public void emp()
        {
            
            Console.WriteLine(firstname+" "+lastname);
            Console.ReadLine();
        }
    }
    public class FullTImeEmploye:Employee
    {
        
    }
    public class PartTimeEmployee:Employee
    {
        public new void emp()
        {
            //base.emp();// this is to use the same member of the base class in the derived class 
            Console.WriteLine("part time employee",firstname + " " + lastname);
            Console.ReadLine();
        }
    }
}