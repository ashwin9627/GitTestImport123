using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ashwin";
            string str2 = "kumar";
          //Compares with the other string and if it's true states 0,1st string < 2nd , It returns 1,and 1st string>2nd string,it returns -1
            Console.WriteLine(string.Compare(str1,str2));
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






            Console.WriteLine("odd number code");
            FindingOddinArray.odd1();
            Console.WriteLine("Even number code");
            FindingOddinArray.even();
            Console.WriteLine("enter numbers to add that all");
            List<int> numbersInput = new List<int>();
            int responsenumber1 = Convert.ToInt32(Console.ReadLine());
            numbersInput.Add(responsenumber1);

            FindingOddinArray.listofnumbers(new List<int>() { responsenumber1 });

            Console.ReadLine();
            Console.WriteLine("List stopped");

            updatedcalc.UpdatedAdd(12, 43);//the obsolete attribute was been assigned so,this will be suggest the use to use the list,
            updatedcalc.UpdatedAdd(new List<int>() { 97, 65, 56, 32 });
           
            Console.ReadLine();//adding multiple number calc
            first:
            Console.WriteLine("Welcome to calculator");
            Console.WriteLine("For Performing Calculations, Press 'calc'");
            Console.WriteLine("For Performing math Operstions, Press 'math'");
            var response = Console.ReadLine();
            var res = response.ToLower();
            if(res=="calc")
            {
                Welcome.welcome();
                var response1=Console.ReadLine();
                var res1 = response1.ToLower();
                if (response1=="1")
                {
                    Add.add(); 
                }
                if (response1 == "2")
                {
                    Sub.sub();
                }
                if (response1 == "3")
                {
                    Div.div();
                }
            }
            if(res=="math")
            {
                Welcome.welcome1();
                var response2 = Console.ReadLine();
                var res2 = response2.ToLower();
                if (res2 == "1")
                {
                    AreaOf_theRectangle.rectangle(); 
                }
                if (res2 == "2")
                {
                    AreaOftheTriangle.triangle();
                }
                if (res2 == "3")
                {
                    AreaOftheCircle.circle();
                }
            }
            Console.WriteLine("PRESS 'YES' IF YOU WANT TO CONTINUE");
            var yes = Console.ReadLine();
            if (yes == "YES" || yes == "yes")
            {
                goto first;
            }
        }
    }
}