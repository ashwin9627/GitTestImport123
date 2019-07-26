using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodPro
{
    class Program
    {
        #region
        static void Main(string[] args)
        {





            //class library execution

         


            //Interface1 i1 = new inter1();
            //i1.print();
            inter2 i2 = new inter2();
            i2.print();
            i2.print1();
            AbstractProgram a1 = new abs1();
            AbstractProgram a2 = new abs2();
            a1.print();
            a2.print();            

            Console.WriteLine("Enter the register number");
            var ing = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            var ing1 = Console.ReadLine();
            properties t1 = new properties();
            t1.SetRegNo(ing);
            t1.SetName(ing1);
            Console.WriteLine("the register number is {0}",+t1.GetRegNo());
            Console.WriteLine("the name of the student is {0}",t1.GetName());
#endregion



            //creating a fulltime employee instance to use the base class features
            FullTImeEmploye FTE = new FullTImeEmploye();
            //now we can access the base class field like firstname and lastname
            FTE.firstname = "ashwin";
            FTE.lastname = "kumar";
            //now printing the first and last name values in the console writeline code in the base class
            //emp is a method of the base class..fulltime emp using the base class properties.
            FTE.emp();
           // Console.ReadLine();

            PartTimeEmployee PTE = new PartTimeEmployee();
            //to display the method on the base class instead of derived we can use this instance.
           // Employee PTE = new PartTimeEmployee();
           //parent class ref variable can point child class, but child class cant refernce parent class eg: partTimeemp=new employee //itz wrong
            PTE.firstname = "Raja";
            PTE.lastname = "Kat";
            //or we can  call the base class method with type castiing
            //((Employee)PTE).emp();//this will call the base class method emp directly.employee is the class name and object and .Method name
            PTE.emp();

            Console.ReadLine();


            //poly

            Poly1[] poly = new Poly1[4];
            poly[0] = new Poly1();
            poly[1] = new FullTimeEmploye();
            poly[2] = new PartTimeEmploye();
            poly[3] = new TemperoryEmployee();

            foreach(var poly2 in poly)
            {
                poly2.emp();
            }
        }
    }
}