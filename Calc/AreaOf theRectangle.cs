using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class AreaOf_theRectangle
    {
        public static void rectangle()
        {
            input_data data = new input_data();
            data.data();

            double area = data.data1 * data.data2;
            double perimeter = 2 * (data.data1 + data.data2);

            Console.WriteLine("The AREA of your rectangle is: {0}", area);
            Console.WriteLine("The PERIMETER of your rectangle is: {0}", perimeter);
            Console.ReadLine();
        }
    }
}
