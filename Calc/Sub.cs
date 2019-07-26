using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Sub:input_data
    {
        public static void sub()
        {
            //Console.WriteLine("enter the number");
            //var sub1 = Console.ReadLine();
            //Console.WriteLine("enter the second number");
            //var sub2 = Console.ReadLine();
            input_data data=new input_data();
            data.data();

          
                Console.WriteLine("The substration of {0} & {1} is =  {2} ", data.data1, data.data2, data.data1 - data.data2);
            Console.ReadLine();
        }


    }
}
