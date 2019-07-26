using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Dictionary1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static void test()
        {
            Dictionary1 d1 = new Dictionary1();

            int i = 100;
            for (i = 1; i < 3; i++)
            {
                IList<Dictionary1> ang = new List<Dictionary1>()
            {
             
                new Dictionary1 { ID = i, Name = "Ashwin", Salary = 30000 },
            new Dictionary1 { ID = i, Name = "Kumar", Salary = 25000 },
            new Dictionary1 { ID = i, Name = "Raj", Salary = 19000 }
            };
        }
                foreach (var aig in ang)
                {
                    Console.WriteLine("ID {0}    Name {1}   salary {2}",aig.ID,aig.Name,aig.Salary);
                }
            }
        
            public static void custdist()
        {
            //Dictionary1 Dic1 = new Dictionary1()
            //{
            //    ID = 100,
            //    Name = "ashwin",
            //    Salary=25000

            //};
            //Dictionary1 Dic2 = new Dictionary1()
            //{
            //    ID = 101,
            //    Name = "Kumar",
            //    Salary = 35000

            //};
            //Dictionary1 Dic3 = new Dictionary1()
            //{
            //    ID = 102,
            //    Name = "Raj",
            //    Salary = 15000

            //};


            //Console.WriteLine("E");

            //Console.ReadLine();
            Dictionary1 D1 = new Dictionary1();
            first:
            Console.WriteLine("Enter your name");

            var e1 = D1.Name;
            e1=Console.ReadLine();

            Console.WriteLine("Enter Your Salary");
            var e2 = D1.Salary;
            e2 = Convert.ToInt32(Console.ReadLine());

            if (e1 != null && e2 != 0)
            {
                int i= 100;
                int Temp = i;
                    //Dictionary<int, Dictionary1> dist200 = new Dictionary<int, Dictionary1>();
                    //dist200.Add(D1.ID,D1.ID);

                    //ArrayList arr = new ArrayList();
                    //arr.Add(D1.ID = i, D1.Name = e1, D1.Salary = e2);

                    //IList<Dictionary1> list = new List<Dictionary1>();
                    //list.Add(D1.ID = i, D1.Name = e1, D1.Salary = e2);
                    FileStream fi = new FileStream("E:\\DummyText3.txt", FileMode.OpenOrCreate);

                    StreamWriter sw = new StreamWriter(fi);
                    StreamReader si = new StreamReader(fi);
                    //    string res1 = (Console.WriteLine(i, e1, e2));
                    
                    sw.WriteLine("Id:{0} Name:{1} Salary{2} ", Temp, e1, e2);
                    Temp=Temp+1;
                    //sw.WriteLine(res2);
                    String line = si.ReadLine();
                Console.WriteLine("Do you want to add one more, If yes Press 'y'");
                var res3=Console.ReadLine();
                res3.ToLower();
                if (res3=="y")
                {
                    goto first;
                }
                    //To Read only one line from the file
                    Console.WriteLine(line);
                    //TO Read All the Lines on the File
                    while ((line = si.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    sw.Close();
                    fi.Close();
                
                }
            }
        public static void dist4()
        {
            Console.WriteLine("Enter your name");

            Dictionary1 D1 = new Dictionary1();

            var e1 = D1.Name;
            e1 = Console.ReadLine();

            Console.WriteLine("Enter Your Salary");
            var e2 = D1.Salary;
            e2 = Convert.ToInt32(Console.ReadLine());


            Dictionary<int, string> My_dict1 =
                       new Dictionary<int, string>();

            // Adding key/value pairs  
            // in the Dictionary 
            // Using Add() method
            int i = 100;
            My_dict1.Add(i, e1);
            i++;
            

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            foreach (var ele2 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele2.Key, ele2.Value);
            }
            Console.WriteLine();
        }








            //Dictionary<int, Dictionary1> dist100 = new Dictionary<int, Dictionary1>();
            //dist100.Add(Dic1.ID, Dic1);
            //dist100.Add(Dic2.ID, Dic2);
            //dist100.Add(Dic3.ID, Dic3);

            //Dictionary1 cust100 = dist100[101];
            //foreach(KeyValuePair<int,Dictionary1>distkeyvalue in dist100)
            //{
            //    Console.WriteLine(distkeyvalue.Key);
            //    Dictionary1 dicvalue = distkeyvalue.Value;
            //    Console.WriteLine("The value of in the ID is {0}, Name: {1}    Salary:{2}",dicvalue.ID,dicvalue.Name,dicvalue.Salary);
               
            //}


        }
    }

