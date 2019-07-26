using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs1
{
    class MaxMin
    {
        public int arr1 { get; set; } 
        public int arr2 { get; set; }
        public int arr3 { get; set; }
        public int arr4 { get; set; }
        public int arr5 { get; set; }
        public int and { get; set; }
        public static void max()
        {
            MaxMin d1 = new MaxMin();
            
            Console.WriteLine("enter any 5 numbers to find the maximum of 5 numbers");
            d1.arr1 = Convert.ToInt32(Console.ReadLine());
            d1.arr2 = Convert.ToInt32(Console.ReadLine());
            d1.arr3 = Convert.ToInt32(Console.ReadLine());
            d1.arr4 = Convert.ToInt32(Console.ReadLine());
            d1.arr5 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { d1.arr1, d1.arr2, d1.arr3, d1.arr4, d1.arr5 };
            int max = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("the maximum number from the given numbers is {0} ",max);
        }
        public static void min()
        {
            MaxMin d1 = new MaxMin();

            Console.WriteLine("enter any 5 numbers to find the maximum of 5 numbers");
            d1.arr1 = Convert.ToInt32(Console.ReadLine());
            d1.arr2 = Convert.ToInt32(Console.ReadLine());
            d1.arr3 = Convert.ToInt32(Console.ReadLine());
            d1.arr4 = Convert.ToInt32(Console.ReadLine());
            d1.arr5 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { d1.arr1, d1.arr2, d1.arr3, d1.arr4, d1.arr5 };
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("the minimum number from the given numbers is {0} ", min);
        }
    }
}
