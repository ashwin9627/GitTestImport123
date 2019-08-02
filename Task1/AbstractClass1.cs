using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AbstractClass1
    {
    }
    interface employee
    {
        void printing();
    }
     public abstract class  abstract1
        {
        public abstract void print();

        public void print1()
        {
            Console.WriteLine("abstract");
        }
        }
     class derived1:abstract1
    {
     public override void print()
        {
            Console.WriteLine("derived class to the abstract method");
        }
    }
    class derived2:abstract1
    {
        public override void print()
        {
            Console.WriteLine("Derived class to the abstract method");
        }
    }
    class interderived:employee
    {
        public void printing()
        {
            Console.WriteLine("interface added to the base class");
        }
    }
    class interderived2:employee
    {
        public void printing()
        {
            Console.WriteLine("implemented 2nd interface from derived to base class interface");
        }
    }
}