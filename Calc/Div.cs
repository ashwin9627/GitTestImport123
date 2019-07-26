using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Div
    {
        public static void div()
        {
            input_data data = new input_data();
            data.data();

            Console.WriteLine("The Division of {0} & {1} is =  {2} ", data.data1, data.data2, data.data1 / data.data2);
            Console.ReadLine();


        }
    }
}
