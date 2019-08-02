using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    class ConstructorProgram
    {
        public int a;
        public int b;
        public int c;

        /// <summary>
        /// we can have use the default constructor to display the custom text for string and custom number for int.If user is not passing parameter to the string cinstructor. It should display the first name not provided etc..
        /// </summary>
        public ConstructorProgram()
            : this(0,0,0)
         {
         }

        public ConstructorProgram(int a1)
        {
            this.a = a1;
        }
        public ConstructorProgram(int a2,int b2)
        {
            this.a = a2;
            this.b = b2;
        }
        //passing 3 parameter into the constructor
        public ConstructorProgram(int a3, int b3,int c3)
        {
            this.a = a3;
            this.b = b3;
            this.c = c3;
        }
        //destructor
        ~ConstructorProgram()
        {

        }
        public void Print()
        {
            Console.WriteLine("{0}  {1}  {2}",this.a, this.b, this.c);
        }
    }
}