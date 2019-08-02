using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class encapsulation1
    {

        //Encapsulation is a wrapping a data into the single unit in the class. Eg:Get & Set

        ///In a scenario we are creating a field id that should not be negative and name should notbe null.If it's a public field we cant control the user not to type a negative number
        ///So then we declare a id as private from public, Now we are creating a set and get method and passing a condition through that id should not be negative and retuen a private id field in that
        ///If the user wants to enter the id,They cant directly access it because it is declared private,so we want to call the set method to set a id and get method to get the id.

        private int _id;
        private string _name;

        //without encapulation, Createing a seperate method access those private field
        public void Setid(int id)
        {
            if(id<0)
            {
                throw new Exception("Id should be a negative number");
            }
            this._id = id;
        }
        public int Getid()
        {
            Console.WriteLine(this._id);
            return this._id;
        }

        public void Setname(string name1)
        {
            
            if(string.IsNullOrEmpty(name1))
            {
                throw new Exception("Name should not be null");
            }
            this._name = name1;
        }
        public void Getname()
        {
            Console.WriteLine(this._name);
 
        }

        ///The above mentioned or done without encapsulation,we have to create a seperate method to make use of each field
        ///Encapsulation makes it easy without creating a seperate method using set and get accessor.

        //With encapsulation

        public int id1
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("id should not be negative or zero");
                }
                this._id = value;
            }
            get
            {
              //  Console.WriteLine(this._id);
                return this._id;
            }
        }
        public string name1
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("name should not be null or empty value ");
                }
                this._name = value;
            }
            get
            {
               // Console.WriteLine(this._name);
                return this._name;
            }
        }

    }
}
