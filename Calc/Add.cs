using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Add:input_data
    {
        public static void add()
        {
            input_data data = new input_data();
            data.data();

            Console.WriteLine("The Addition of {0} & {1} is =  {2} ",data.data1,data.data2,data.data1 + data.data2);
            Console.ReadLine();
           

        }
    }
}
