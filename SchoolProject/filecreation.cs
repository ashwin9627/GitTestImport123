using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class filecreation
    {
        public static void filecreate()
        {
            Console.WriteLine("Enter the line to add on the text file");
            var res1 = Console.ReadLine();
            Console.WriteLine("Enter the second line to add on the text file");
            var res2 = Console.ReadLine();

            FileStream fi = new FileStream("E:\\DummyText2.txt",FileMode.OpenOrCreate);
          
            StreamWriter sw = new StreamWriter(fi);
            StreamReader si = new StreamReader(fi);
            sw.WriteLine(res1);
            sw.WriteLine(res2);
            String line = si.ReadLine();
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

        public static void serialize()
        {
            FileStream stream = new FileStream("E:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            // Student s = new Student(101, "sonoo");
            var s = "This is a serializable data";
            formatter.Serialize(stream, s);
            stream.Close();
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}