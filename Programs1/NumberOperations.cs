using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs1
{
    class NumberOperations
    {
        public int arr1 { get; set; }
        public int arr2 { get; set; }
        public int arr3 { get; set; }
        public int arr4 { get; set; }
        public int arr5 { get; set; }
        public int and { get; set; }
        public static void neg()
        {
            NumberOperations N1 = new NumberOperations();
            first:
            Console.WriteLine("enter any 5 numbers to find the negative numbers");
            N1.arr1 = Convert.ToInt32(Console.ReadLine());
            N1.arr2 = Convert.ToInt32(Console.ReadLine());
            N1.arr3 = Convert.ToInt32(Console.ReadLine());
            N1.arr4 = Convert.ToInt32(Console.ReadLine());
            N1.arr5 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { N1.arr1, N1.arr2, N1.arr3, N1.arr4, N1.arr5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("Negative numbers in the input that you given is {0}", arr[i]);

                }
            }
            Console.WriteLine("Do you want to check another number, If yes press 'y'");
            var res5 = Console.ReadLine();
            if (res5 == "y")
            {
                goto first;
            }

        }
        public static void pos()
        {
            NumberOperations N1 = new NumberOperations();
            first:
            Console.WriteLine("enter any 5 numbers to find the negative numbers");
            N1.arr1 = Convert.ToInt32(Console.ReadLine());
            N1.arr2 = Convert.ToInt32(Console.ReadLine());
            N1.arr3 = Convert.ToInt32(Console.ReadLine());
            N1.arr4 = Convert.ToInt32(Console.ReadLine());
            N1.arr5 = Convert.ToInt32(Console.ReadLine());

            int[] arr = { N1.arr1, N1.arr2, N1.arr3, N1.arr4, N1.arr5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine("Positive numbers in the input that you given is {0}", arr[i]);

                }

            }
            Console.WriteLine("Do you want to check another number, If yes press 'y'");
            var res5 = Console.ReadLine();
            if (res5 == "y")
            {
                goto first;
            }

            Console.ReadLine();
        }
        public static void oddeven()
        {
            first:
            Console.WriteLine("enter the number to finf whether it is odd or even");
            int res1 = Convert.ToInt32(Console.ReadLine());
            if (res1 % 2 == 0)
            {
                Console.WriteLine("{0} is a even number", res1);
            }
            else
            {
                Console.WriteLine("{0} is a odd number", res1);
            }

            Console.WriteLine("Do you want to check another number, If yes press 'y'");
            var res5 = Console.ReadLine();
            if (res5 == "y")
            {
                goto first;
            }
        }
        public static void armstrong()
        {
            first:
            Console.WriteLine("Enter a number to find whether the number is armstrong number or not");
            var n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            while (n > 0)
            {
                int a = n % 2;
                n = n / 10;
                c = c + (a * a * a);
            }
            if (n == c)
            {
                Console.WriteLine("{0} is a armstrong number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a palindromed number", n);
            }
            Console.WriteLine("if you want to perform another operation, Click 'y'");
            var sss=Console.ReadLine();
            if(sss=="y")
            {
                goto first;
            }
        }
        public static void fibo()
        {
            int a = 0;
            int b = 1;
            int c = a + b;
            for (int i = 2; i < 10; ++i)//loop starts from 2 because 0 and 1 are already printed    
            {
                c = a + b;
               Console.WriteLine(" " + c);
                a = b;
                b = c;
            }
        }       
    }
}