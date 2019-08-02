using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int Age{get;set;}

        public int salary { get; set; }
        public string Country { get; set; }
        public string city { get; set; }

        public string desigination { get; set; }



    }
     class EmployeeDetails
    {
        public IList<Employee> listemp = new List<Employee>()
        {
                new Employee{firstname="Ashwin",lastname="kumar",Age=23,Country="india",city="Salem",salary=20000,desigination="Developer"},
                new Employee{firstname="Kumar",lastname="raj",Age=34,Country="India",city="chennai",salary=30000,desigination="Developer"},
                new Employee{firstname="sam",lastname="johnie",Age=31,Country="India",city="Bangalore",salary=34000,desigination="Tester"},
                new Employee{firstname="stephen",lastname="Raj",Age=30,Country="india",city="Mumbai",salary=23000,desigination="Sales"}
         };

        List<Employee> list1 = new List<Employee>()
        {
            new Employee{firstname="Raj",lastname="kumar"},
            new Employee{firstname="dom",lastname="steve" }
        };

        //List<Employee> emplist = new List<Employee>();
        //new Employee { firstname = "ashwin", lastname = "kumar", Age = 32, Country = "India", city = "chennai" };
        //new Employee { firstname = "Raj", lastname = "kumar", Age = 21, Country = "India", city = "Bangalore" };
        //new Employee { firstname = "stephen", lastname = "Raj", Age = 25, Country = "USA", city = "New York" };
        //new Employee { firstname = "Sam", lastname = "felling", Age = 21, Country = "USA", city = "New York" };
        //new Employee { firstname = "Abdul", lastname = "Karem", Age = 26, Country = "UK", city = "New York" };

        public void disp()
        {
         IList<Employee> employeelist = new List<Employee>()
            {
                new Employee{firstname="Ashwin",lastname="kumar",Age=23,Country="india",city="Salem"},
                new Employee{firstname="Kumar",lastname="raj",Age=34,Country="India",city="chennai"},
                new Employee{firstname="sam",lastname="johnie",Age=31,Country="India",city="Bangalore"},
                new Employee{firstname="stephen",lastname="Raj",Age=30,Country="india",city="Mumbai"}
                };
    }
    
    }
}
