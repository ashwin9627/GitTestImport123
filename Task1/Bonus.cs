using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Bonus : EmployeeDetails
    {
        public int bonus{ get;set; }
        public void empdetails()
        {
            EmployeeDetails emp = new EmployeeDetails();
            foreach(var det in emp.listemp)
            {


                if (det.desigination == "Developer")
                {
                    bonus = 10000;
                }
                if (det.desigination == "Tester")
                {
                    bonus = 7000;
                }
                if (det.desigination == "Sales")
                {
                    bonus = 5000;
                }
                Console.WriteLine("employee {0} salary have credited with bonus {1} ", det.firstname,det.salary+bonus);
            }
        }
    }
    public class Developer
    { 
        public void developer()
    {
    }
}
    public class Tester
    {
        public void tester()
        {

        }
    }
    public class Sales
    {
        public void sales()
        {


        }
    }
    }

