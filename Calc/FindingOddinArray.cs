using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class FindingOddinArray
    {
        public static void odd1()
        {
            int[] arr = { 11, 22, 4, 5, 7, 18, 90 };

            int sum = 0;
          
         foreach(int ang in arr)
            {
                if(ang%2!=0)
                {
                    sum = sum + ang;
                }
            }
            Console.WriteLine(sum);
        }
        public static void even()
        {
            int[] arr1 = { 10, 3, 7, 12, 20, 2, 3, 5 };
           int sum = 0;
            for(int i=0;i<arr1.Length;i++)
            {
                if(arr1[i]%2==0)
                {
                    sum = sum + arr1[i];
                    
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("Length of the array is "+ arr1.Length);
        }
        public static void listofnumbers(List<int>numbers)
        {
            int sum = 0;
            foreach(var num in numbers)
            {
                sum = sum + num;
            }
            Console.WriteLine(sum);

        }
        public void numberlist100()
        {
            input_data i1 = new input_data();
            i1.data1 = 287;
            i1.data2 = 7238;
        }
    }
}