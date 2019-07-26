using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    public abstract class AbstractProgram 
    {
        public int a = 1;
        //abstract may contain fields and some of declarations with them
        //We can use abstract keyword for method but it is not so manditory as like interface
        //Public abstract print();
        public virtual void print()//we can do implementation using normal method,By using virtual keyword the derived class method can overrides the abstract class method.
    {
            Console.WriteLine("hello World");
    }
}
    public class abs1:AbstractProgram
    {
        public override void print()//print method should be used for must as it is implemented in abstract base class,it overrides the base class method
        {
            Console.WriteLine("hello universe");
        }
    }
    public class abs2:AbstractProgram
    {
        public override void print()
        {
            Console.WriteLine("This overrides the abstract method");
        }
    }
    }
