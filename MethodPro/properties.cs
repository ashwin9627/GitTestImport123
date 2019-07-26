using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPro
{
    class properties
    {
        private string Name { get; set; }
        private int Regno { get; set; }
        public int Age { get; set; }

        public static string school = "SRK School";

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name could not be null or empty");
               // Console.WriteLine("Name could not be Null or empty");

            }
            this.Name = name;
        }
        public String GetName()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                return "no name";
            }
            else
            {
                return this.Name;
            }
        }
        public void SetRegNo(int regno)
        {
            if (regno < 0)
            {
                throw new Exception("You cant declare a register number as negative");
               // Console.WriteLine("you cant declare register number as negative");
            }
            this.Regno = regno;
        }
        public int GetRegNo()
        {
            return this.Regno;
        }
    }
}