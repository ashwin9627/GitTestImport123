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