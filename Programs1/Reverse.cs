using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs1
{
    class Reverse
    {
        public static void rev()
        {
            Console.WriteLine("Enter the Number to check Whether it is palindrome and to view the reverse of the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int r;
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                r = n %10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            Console.WriteLine("Reverse of {0} is {1}", temp, sum);
            if (temp == sum)
            {
                Console.WriteLine("{0} is a palindrome number", sum);
            }
            else
            {
                Console.WriteLine("It is not a palindrome number");
            }
        }
        public static void revstring()
        {
            Console.WriteLine("Enter the String to reverse");
            string res = Console.ReadLine();
            int len = res.Length-1;
            string reverse = "";
            foreach(var rev1 in res)
            {
                reverse = reverse + res[len];
                len--;
                
            }
            Console.WriteLine("the reverse of {0} is {1}",res,reverse);
        }
    }
}
