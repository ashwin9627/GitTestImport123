using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    //Interface is declared using interface keyword in the class
    //Interface cannot contain any implementation,just a declaration of method,It wont contain ant field.
    //The method in the interface should be used for must in the derived classes.
    //multiple interface inheritance is possible, public in the interface method is wrong where as interface is public by default.
    interface Interface1
    {
        void print();
    }
    interface Interface2
    {
        void print1();
    }
    public class inter1:Interface1
        {
        public void print()
        {
            Console.WriteLine("Interface is implemented");
        }
        }
    public class inter2 : Interface2,Interface1
    {
        public void print()
        {
            Console.WriteLine("Interface is implemented 2");
        }
        public void print1()
        {
            Console.WriteLine("Interface print1 is implemented 2");
        }
    }
}