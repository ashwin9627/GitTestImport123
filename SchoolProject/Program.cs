using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            filecreation.serialize();
            filecreation.filecreate();
            PrintAlphabets.alpha();
            PrintAlphabets.WriteAlpha();
            first:

            StartPage.Welcome();
            int response= Convert.ToInt32(Console.ReadLine());
            if (response==1)
            {
                Attentance.attend1();
            }
            if(response==2)
            {
                Teachers t1 = new Teachers();
                t1.teacherdata();
            }
            if(response==3)
            {
                Marks.mark();
                Console.ReadLine();
            }
            if (response == 4)
            {
                Console.WriteLine("Staffs Login");
                Console.WriteLine("\n Enter your User Id");
                var response1 = Console.ReadLine();
                Console.WriteLine("Enter your Password");
                var response2 = Console.ReadLine();
                Console.WriteLine("to you want to filter salary, If yes press 100");
                var response100 = Convert.ToInt32(Console.ReadLine());
                if (response100==100)
                {
                    Teachers.FilterSalary();
                    Console.ReadLine();
                }

                if (response1 == "ashwin" && response2 == "pass"  || response1=="kumar" && response2=="pass1" || response1 == "admin" && response2 == "admin")
                {
                    //Teachers t1 = new Teachers();
                    Teachers.TeacherPersonaldata();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid User");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("PRESS 'YES' IF YOU WANT TO CONTINUE");
            var yes = Console.ReadLine();
            if(yes=="YES" || yes=="yes")
            {
                goto first;
            }
        }
    }
}