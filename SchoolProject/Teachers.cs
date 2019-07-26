using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Teacher
    {

        public string Teacher_Name { get; set; }
        public string Subject_Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public int phonenumber{ get; set; }
        public string address { get; set; }
        


    }
    class Teachers
    {
        IList<Teacher> Teacher123 = new List<Teacher>()
            {
                new Teacher{Teacher_Name="Malar",Subject_Name="English"},
                new Teacher{Teacher_Name="Sam",Subject_Name="Maths"},
                new Teacher{Teacher_Name="Johnny",Subject_Name="Science"},
                new Teacher{Teacher_Name="Bravo",Subject_Name="Computer Science"},
                new Teacher{Teacher_Name="Hena",Subject_Name="Social"},
                };
        public void teacherdata()
        {
            foreach(var tea in Teacher123)
            {
                Console.WriteLine("Teacher Name- {0}    Subject Taken-  {1}", tea.Teacher_Name , tea.Subject_Name);
                Console.WriteLine("....................................................................");
            }
            Console.ReadLine();
        }
        public static void TeacherPersonaldata()
        {
            IList<Teacher> Teacher1234 = new List<Teacher>()
            {
                new Teacher{Teacher_Name="Malar",Subject_Name="English", Experience=5,phonenumber=87765554,address="bangalore" ,Salary=15000},
                new Teacher{Teacher_Name="Sam",Subject_Name="Maths",Experience=7,phonenumber=87765554,address="Mumbai" ,Salary=20000},
                new Teacher{Teacher_Name="Johnny",Subject_Name="Science",Experience=2,phonenumber=87765554,address="chennai" ,Salary=10000},
                new Teacher{Teacher_Name="Bravo",Subject_Name="Computer Science",Experience=3,phonenumber=87765554,address="bangalore" ,Salary=12000},
                new Teacher{Teacher_Name="Hena",Subject_Name="Social",Experience=1,phonenumber=87765554,address="Kochi" ,Salary=8000},
                };
             foreach(var tea1 in Teacher1234)
            {
  
                Console.WriteLine("Teacher name:{0} Subject Name:{1}Experience: {2}Phone Number:{3}address:{4}  salary: {5} ",tea1.Teacher_Name,tea1.Subject_Name,tea1.Experience,tea1.phonenumber,tea1.address,tea1.Salary);
            }
        }
        public static void FilterSalary()
        {
            IList<Teacher> Teacher123 = new List<Teacher>()
            {
                new Teacher{Teacher_Name="Malar", Experience=5,phonenumber=87765554,address="bangalore" ,Salary=15000},
                new Teacher{Teacher_Name="Sam",Experience=7,phonenumber=87765554,address="Mumbai" ,Salary=20000},
                new Teacher{Teacher_Name="Johnny",Experience=2,phonenumber=87765554,address="chennai" ,Salary=10000},
                new Teacher{Teacher_Name="Bravo",Experience=3,phonenumber=87765554,address="bangalore" ,Salary=12000},
                new Teacher{Teacher_Name="Hena",Experience=1,phonenumber=87765554,address="Kochi" ,Salary=8000},
                };
            Console.WriteLine("filter the salary of teacher here");
            Console.WriteLine("enter starting salary");
            var response1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter salary upto");
            var response2 = Convert.ToInt32(Console.ReadLine());
            var salary = from s in Teacher123
                                  where s.Salary > response1 && s.Salary < response2
                                  select s;


            Teachers T11 = new Teachers();

            foreach (var tea1 in salary)
            {
                
                    Console.WriteLine("Teacher name:{0} Subject Name:{1}Experience: {2}Phone Number:{3}address:{4}  salary: {5} ", tea1.Teacher_Name, tea1.Subject_Name, tea1.Experience, tea1.phonenumber, tea1.address, tea1.Salary);
                
                
            }
        }
        //t2.TeacherPersonaldata.Teacher123();
        //var t1=Teachers.TeacherPersonaldata();
    }
    }