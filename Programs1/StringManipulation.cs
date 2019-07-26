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
        public static void String_Method()
        {
            string str1 = "ashwin";
            string str2 = "kumar";
            //Compares with the other string and if it's true states 0,1st string < 2nd , It returns 1,and 1st string>2nd string,it returns -1
            Console.WriteLine(string.Compare(str1, str2));

            //Compares with the other string and if it's true states 0,1st string < 2nd , It returns positive,and 1st string>2nd string,it returns negative
            Console.WriteLine(string.CompareOrdinal(str1, str2));

            //compares the string with another
            Console.WriteLine(str1.CompareTo(str2));

            //Concatinate 2 string(joins)
            Console.WriteLine(string.Concat(str2, str1));

            //check whether it contains same as str1
            Console.WriteLine(str1.Contains(str2));

            //Copy
            string str3 = string.Copy(str1);
            Console.WriteLine(str1);

            //Copy Toc, it copies the a char in the index and copies upto the fixed index
            string s1 = "Hello C#, How Are You?";
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);


            //checks whether it ends with the same char
            Console.WriteLine(str1.EndsWith(str2));

            //Checks whether Str1 equals str2
            Console.WriteLine(str1.Equals(str2));

            //it returns the current date as a output
            string s11 = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(s11);


            //it will make the string inton the object enumurator which we can loop through it.
            string s2 = "Hello C#";
            CharEnumerator ch1 = s2.GetEnumerator();
            while (ch1.MoveNext())
            {
                Console.WriteLine(ch1.Current);
            }

            //To get a hashcode of a string,it returns integer output
            Console.WriteLine(str1.GetHashCode());

            //To get the type of the datatype
            Console.WriteLine(s1.GetType());

            //Is used to get type code of a string
            Console.WriteLine(s1.GetTypeCode());

            //IndexOf is used to find in which index did the character located
            int index = s1.IndexOf('e');
            Console.WriteLine(index);


            //It will insert the char to the s12 
            string s12 = "Hello C#";
            string s22 = s12.Insert(5, "-");
            Console.WriteLine(s2);


            //intern used to retrive reference of the particular string
            string s3 = string.Intern(s1);

            //intered reverive reference of the particular string
            string s33 = string.IsInterned(s1);

            //check whether the string is unicode normalization form
            string s31 = "Hello C#";
            bool b1 = s1.IsNormalized();
            Console.WriteLine(s31);
            Console.WriteLine(b1);

            //Check whether the normazlized and produce the string value,
            string s32 = s1.Normalize();
            Console.WriteLine(s32);

            //Null or empty, It is used to check the string is either null or empty
            string s01 = "Hello C#";
            string s02 = "";
            bool b01 = string.IsNullOrEmpty(s01);
            bool b02 = string.IsNullOrEmpty(s02);
            Console.WriteLine(b01);
            Console.WriteLine(b02);

            //Null or WhiteSpace,Check whether the string contains null or whitespace
            bool b40 = string.IsNullOrWhiteSpace(s01);
            Console.WriteLine(b40);

            //join concodinates with the array with the sepearator b/w them
            string[] s100 = { "Hello", "C#", "by", "javatpoint" };
            string s300 = string.Join("-", s100);
            Console.WriteLine(s300);

            //Index of is used to find the character index and last index of is used to find the last index of the specified character.
            string s111 = "Hello C#";
            int first = s111.IndexOf('l');
            int last = s111.LastIndexOf('l');
            Console.WriteLine(first);
            Console.WriteLine(last);

            //Last Index of Any will be used to find the last index with one or more char,like r before b,it will find from last wh=here r is present beside b.
            string s112 = "abracadabra";
            char[] ch11 = { 'r', 'b' };
            int index1 = s112.LastIndexOfAny(ch11);//Finds 'r' at the last  
            Console.WriteLine(index1);

            //string PadLeft is used to align the string to right if the string char is less than the specified length,it adds whitespace.
            string s211 = "Hello C#";// 8 length of characters  
            string s212 = s211.PadLeft(10);//(10-8=2) adds 2 whitespaces at the left side  
            Console.WriteLine(s212);

            //The C# PadRight() method is used to get a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.
            string s213 = "Hello C#";// 8 length of characters  
            string s214 = s213.PadRight(15);
            Console.Write(s214);//padding at right side (15-8=7)  
            Console.Write("JavaTpoint");//will be written after 7 white spaces

            //Remove ,String remove will display the balance letters on the string after removed from the string

            string s301 = "abcdefghijk";
            string s302 = s301.Remove(4, 5);
            Console.WriteLine(s302);

            //String replace is used to replace the letter instead of other letter in the string

            string s215 = "Hello F#";
            string s216 = s215.Replace('F', 'C');
            Console.WriteLine(s216);

            //C# split method is used to split the string into substrings in the array and we can split using whitespaces,comma etc..
            string s217 = "Hello C Sharp";
            string[] s218 = s217.Split(' ');
            foreach (string s219 in s218)
            {
                Console.WriteLine(s219);
            }

            //String Starts with method will checks whether the letter we mentioned matches with the string or not.
            string s221 = "Hello C Sharp";
            bool b221 = s221.StartsWith("h");
            bool b222 = s221.StartsWith("H");
            Console.WriteLine(b221);
            Console.WriteLine(b222);

            //Substring method will get the substring of the method from the index we mentioned and follow 
            string s401 = "Hello C Sharp";
            string s402 = s401.Substring(5);
            Console.WriteLine(s402); //o/p will be C Sharp

            // TocharArray is To get the char Array from the string object
            string s501 = "Hello C#";
            char[] ch501 = s501.ToCharArray();
            foreach (char c in ch501)
            {
                Console.WriteLine(c);//op will be like H e l l o C #
            }

            //String ToLower method is used to make or convert the string to lower case
            string s131 = "Hello C#";
            string s231 = s131.ToLower();
            Console.WriteLine(s231);

            //It is used to convert the string to lower case in invarient culture
            string s141 = "Hello C#";
            string s241 = s141.ToLowerInvariant();
            Console.WriteLine(s241); //o/p : hello c#

            //To string, To get the instance of the string,it will make the int to string format and display it.
            string s291 = "Hello C#";
            int a = 123;
            string s292 = s291.ToString();
            string s293 = a.ToString();
            Console.WriteLine(s292);//Hello c#
            Console.WriteLine(s293);//o/p 123 as a string

            //Toupper Case is used to convert the string to Upper Case.
            string s1000 = "Hello C#";
            string s3000 = s1000.ToUpper();
            Console.WriteLine(s3000);//o/p: HELLO C#

            //TO UpperInvariant it will convert the string to the upper case in invariant culture 
            string s2000 = "Hello C#";
            string s4000 = s2000.ToUpperInvariant();
            Console.WriteLine(s4000);

            //trim() is used to remove the unwanted whitespace on the string
            string s6000 = "Hello C#";
            string s7000 = s6000.Trim();
            Console.WriteLine(s7000);

            //The C# TrimEnd() method is used to remove all trailing occurrences of a set of characters specified in an array from the current String object.
            string s500 = "Hello C#";
            char[] ch500 = { '#' };
            string s2600 = s500.TrimEnd(ch500);
            Console.WriteLine(s2600);//it will removes the # from the string and dislay the string

            //The C# TrimStart() method id used to remove all leading occurrences of a set of characters specified in an array from the current String object.
            string v1 = "Hello C#";
            char[] ch007 = { 'H' };
            string v2 = v1.TrimStart(ch007);
            Console.WriteLine(v2);
        }
    }
}
