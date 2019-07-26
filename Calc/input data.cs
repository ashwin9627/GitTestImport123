using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class input_data
    {
        public double data1 { get; set; }
        public double data2 { get; set; }
        public void data()
        {
            Console.WriteLine("enter the number");
            data1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            data2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Addition of {0} and {1} is", add1 + add2);

        }
    }
}
