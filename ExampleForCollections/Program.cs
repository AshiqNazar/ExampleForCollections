using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add("Ashiq");
            //al.Add(123);
            //al.Add(24.2);
            //al.Add('t');

            //foreach (object o in al)
            //{
            //    Console.WriteLine(o);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add("01", "Testing");
            //ht.Add("ora", "oracle");
            //ht.Add("vb", "vb.net");
            //ht.Add("cs", "cs.net");
            //ht.Add("asp", "asp.net");

            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine(d.Key + " :" + d.Value);
            //}

            //SortedList sl = new SortedList();
            //sl.Add("ora", "oracle");
            //sl.Add("vb", "vb.net");
            //sl.Add("cs", "cs.net");
            //sl.Add("asp", "asp.net");

            //foreach (DictionaryEntry d in sl)
            //{
            //    Console.WriteLine(d.Key + " " + d.Value);
            //}

            int[] array = { 1, 2, 3, 4, 5, 6 };
            string[] array2 = { "Ashiq", "Reshmi" };
            Console.WriteLine(array2[0]);
            Console.WriteLine(array[1]);

            ArrayList al = new ArrayList();
            al.Add("Ashiq");
            al.Add(123);
            al.Add(true);

            al.Add(23.5);
            al.Insert(2, "aydu");
            Console.WriteLine(al[2]);

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }



            Hashtable ht = new Hashtable();
            ht.Add("ash", "Ashiq");
            ht.Add("001", "ashiq");
            ht.Add("email", "Ashiq@gmail.com");
            ht.Add("Place", "Palakkad");
            ht.Add("Country", "India");

            // Console.WriteLine(ht["ash"]);

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " :" + d.Value);
            }

            SortedList sl = new SortedList();
            sl.Add("ash", "Ashiq");
            sl.Add("001", "ashiq");
            sl.Add("email", "Ashiq@gmail.com");
            sl.Add("Place", "Palakkad");
            sl.Add("Country", "India");
            sl.Remove("Place");
            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " :" + d.Value);
            }
            Console.ReadKey();
        }
    }
}
