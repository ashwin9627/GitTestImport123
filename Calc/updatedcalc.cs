using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class updatedcalc
    {
        [Obsolete("Use (List<int>numbers) for Add")]
        public static int UpdatedAdd(int a,int b)
        {
            
            return a + b;
        }
            public static void UpdatedAdd(List<int>numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                sum = sum + number;
            }
            Console.WriteLine(sum);
            
        }
    }
}
