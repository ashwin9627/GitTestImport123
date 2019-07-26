using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Marks:StudentInfoDetails
    {
        public String Subject { get; set; }
        public int marks { get; set; }
        public int regno { get; set; }
        public static void mark()
        {
            StudentInfoDetails sid = new StudentInfoDetails();
            IList<Marks> ang = new List<Marks>()
            {
            new Marks{regno=110,marks=296},
            new Marks{regno=111,marks=490},
            new Marks{regno=112,marks=390},
            new Marks{regno=113,marks=145},
            new Marks{regno=114,marks=340},
            new Marks{regno=115,marks=230},
            new Marks{regno=116,marks=450},
            new Marks{regno=117,marks=299},
            new Marks{regno=118,marks=560},
            new Marks{regno=119,marks=390}
            };
            
                foreach ( var ind in sid.stu)
            {

                foreach (var vang in ang)
                {
                    if (ind.Regno == vang.regno)
                    {
                        Console.WriteLine("Name:{0}   Register number:{1}   Mark{2}", ind.Name, vang.regno, vang.marks);
                        // Console.WriteLine("...................................");
                    }
                }
                //Console.WriteLine("Name{0}   Register Number{1}",ind.Name, ind.Regno);
                //Console.WriteLine("...................................");
            }
          
        
        }
    }
}
