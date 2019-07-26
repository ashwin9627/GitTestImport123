using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs1
{
    class StringManipulation
    {
        public static void str()
        {
            Console.WriteLine("Enter the String value to perform manipulations");
            String str = Console.ReadLine();
         //   str = "ashwin";
            StringBuilder sb = new StringBuilder(str);
            Console.WriteLine("Enter to insert to the string you entered");
            String str1=Console.ReadLine();
            sb.Insert(1, str1);
            Console.WriteLine(sb);
            Console.WriteLine("Enter the String to remove the string letter from index 3 to 5");
            var str2 = Convert.ToInt32(Console.ReadLine());
            var str3 = Convert.ToInt32(Console.ReadLine());

            sb.Remove(str2, str3);
            Console.WriteLine(sb);
            Console.WriteLine("Enter the String to append at last");
            var str4 =Console.ReadLine();

            sb.Append(str4);
            
            Console.WriteLine(sb);
            Console.WriteLine("TO find the maximum capacity of the word that we entered is {0}",sb.MaxCapacity);
            Console.WriteLine("TO find the type of the data that we entered is {0}",sb.GetType());
            Console.WriteLine("This will replace the letter a to @ in the word      {0}",sb.Replace("a","@"));

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
