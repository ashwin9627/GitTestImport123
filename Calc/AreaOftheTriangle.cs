using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class AreaOftheTriangle:input_data
    {
        public static void triangle()
        {
            input_data data = new input_data();
            data.data();
           decimal area =Convert.ToDecimal( data.data1 * data.data2) / 2 ;
            //  double area1 = (data.data1 * data.data2) / 2;
            Console.WriteLine("the are of the triangle is {0}", area);
        }
    }
}
