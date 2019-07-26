using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Perform Reverse operation Press '1' ");
            Console.WriteLine("To Perform Reverse String operation Press '2' ");
            Console.WriteLine("To find the maximum number Press '3' ");
            Console.WriteLine("To find the minimum number Press '4' ");
            Console.WriteLine("To Perform String Manipulation Press '5' ");
            Console.WriteLine("To Perform Number Operation Press '6' ");

            var res = Convert.ToInt32(Console.ReadLine());
            if (res == 1)
            {
                Reverse.rev();
                
            }
            if(res==2)
            {
                Reverse.revstring();
                Console.ReadLine();
            }
            if (res == 3)
            {
                MaxMin.max();
                Console.ReadLine();
            }
            if (res == 4)
            {
                MaxMin.min();
                Console.ReadLine();
            }
            if(res==5)
            {
                StringManipulation.str();
                Console.ReadLine();
            }
            if (res == 6)
            {
                NumberOperations.neg();
                Console.ReadLine();
                NumberOperations.pos();
                Console.ReadLine();
                NumberOperations.oddeven();
                NumberOperations.armstrong();
                NumberOperations.fibo();
                Console.ReadLine();
            }
        }
    }
}
