using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class dist2
    {
        static string userInput;
        static string val;
        static string key;

        static Dictionary<string, string> dict = new Dictionary<string, string>();



        public static void dist21()
        {
            Console.WriteLine("Write any word");
            userInput = Console.ReadLine();

            string[] wordbits = userInput.Split(' ');



            for (int i = 0; i < wordbits.Length - 1; i += 2)
            {
                key = wordbits[i];
                val = wordbits[(i + 1)];

                dict.Add(key, val);
            }
            Console.WriteLine(dict.Count);
            Console.WriteLine(dict.Keys);
            Console.WriteLine(dict.Values);
            //for (int j = 0; j < wordbits.Length; j++)
            //    {
            //        val = wordbits[(j + 1)];
            //    }

            //dict.Add(key, val);
        }
            //
          
            //
public static void dict5()
        {
            First:
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            int i;
            int k=100;
            for (i=0; i<10;i++)
            {

                Console.WriteLine("Id is {0} and name is {1}", k, name);
                k = k + 1;
                goto First;
                Console.ReadLine();
                //Dictionary<int, string> My_dict1 =
                //      new Dictionary<int, string>();
                //My_dict1.Add(k, name);
                //i++;


                //foreach (KeyValuePair<int, string> ele1 in My_dict1)
                //{
                //    Console.WriteLine("{0} and {1}",
                //              ele1.Key, ele1.Value);
                //}
                //foreach (var ele2 in My_dict1)
                //{
                //    Console.WriteLine("{0} and {1}",
                //              ele2.Key, ele2.Value);
                //}
            }

               k = k + 1;
            
        }


        }

    }
