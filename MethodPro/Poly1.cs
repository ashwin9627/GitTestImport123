using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    public class Poly1
    {

        public string firstname = "Ashwin";
        public string lastname = "Kumar";

        //OverRiding
        //virtual keyword is used to get overrided by other child classes of the base class.
        public virtual void emp()
        {
            Console.WriteLine(firstname + " " + lastname);
            Console.ReadLine();
        }
    }
    public class FullTimeEmploye : Poly1
    {

    }
    public class PartTimeEmploye : Poly1
    {
        //It will override the base class method
        //public new void emp() //new keyword is used for the method hiding , This will hide the base class method emp() 
        public override void emp() //Override keyword overides the base case method and prints derived class data. 
        {
            //base.emp();// this is to use the same member of the base class in the derived class 
            Console.WriteLine("part time employee  " + firstname + " " + lastname);
            Console.ReadLine();
        }
    }
    public class TemperoryEmployee : Poly1
    {
    }
    //Method Overloading
    public class overload
    {
        public void overload1(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void overload1(int a,int b,int c)
        {
        }
        public void overload1(int a, int b, out int c)
        {
            a = 10;
            b= 20;
            c = a+b;
            Console.WriteLine(c);
                   }
        public void overload1(float a,float b)
        {
        }
        public void overload1(int a, float b) 
        {
        }
    }
}