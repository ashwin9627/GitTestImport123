using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class PrintAlphabets
    {
        public static void alpha()
        {
            FileStream fi = new FileStream("E:\\DummyText1.txt", FileMode.OpenOrCreate);
            for(int i=65; i<=90;i++)
            {
                fi.WriteByte((byte)i);              
            }
            fi.Close();
        }
        public static void WriteAlpha()
        {
            FileStream fi = new FileStream("E:\\DummyText1.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = fi.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
        }
    }
}