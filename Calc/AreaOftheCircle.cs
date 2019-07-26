using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class AreaOftheCircle
    {
        public static void circle()
        {
            input_data data = new input_data();
            data.data();
            double pi = 3.14;
            double radius = data.data1;
            double area = pi * (radius * radius);
            Console.WriteLine("The Area (A=πr2) of your circle is: {0:0.00}", area);
        }
    }
}
