using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Attentance:StudentInfoDetails
    {
        public static void attend1()
        {
            // ArrayList studentlist = new ArrayList();
            IList<Student_info> stu = new List<Student_info>()
            {
                new Student_info{Name="Ashwin",Regno=110,Age=15},
                new Student_info{Name="Kumar",Regno=111,Age=15},
                new Student_info{Name="Raj",Regno=112,Age=16},
                new Student_info{Name="Raja",Regno=113,Age=15},
                new Student_info{Name="Ram",Regno=114,Age=16},
                new Student_info{Name="Manoj",Regno=115,Age=16},
                new Student_info{Name="Sam",Regno=116,Age=14},
                new Student_info{Name="Stack",Regno=117,Age=16},
                new Student_info{Name="Jarvis",Regno=118,Age=17},
                new Student_info{Name="Banner",Regno=119,Age=17},
                };

            foreach (var attand in stu)
            {
                Console.WriteLine("Register.no-  {0}              Name-   {1}     School-{2}",attand.Regno,attand.Name,Student_info.school);
                Console.WriteLine("....................................................................");
               
            }
            Console.ReadLine();
        }
    }
}
