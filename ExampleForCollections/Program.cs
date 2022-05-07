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

            //int[] array = { 1, 2, 3, 4, 5, 6 };
            //string[] array2 = { "Ashiq", "Reshmi" };
            //Console.WriteLine(array2[0]);
            //Console.WriteLine(array[1]);

            //ArrayList al = new ArrayList();
            //al.Add("Ashiq");
            //al.Add(123);
            //al.Add(true);

            //al.Add(23.5);
            //al.Insert(2, "aydu");
            //Console.WriteLine(al[2]);

            //foreach (object item in al)
            //{
            //    Console.WriteLine(item);
            //}



            //Hashtable ht = new Hashtable();
            //ht.Add("ash", "Ashiq");
            //ht.Add("001", "ashiq");
            //ht.Add("email", "Ashiq@gmail.com");
            //ht.Add("Place", "Palakkad");
            //ht.Add("Country", "India");

            //Console.WriteLine(ht["ash"]);

            //foreach (DictionaryEntry d in ht)
            //{
            //    Console.WriteLine(d.Key + " :" + d.Value);
            //}

            //SortedList sl = new SortedList();
            //sl.Add("ash", "Ashiq");
            //sl.Add("001", "ashiq");
            //sl.Add("email", "Ashiq@gmail.com");
            //sl.Add("Place", "Palakkad");
            //sl.Add("Country", "India");
            //sl.Remove("Place");
            //foreach (DictionaryEntry d in sl)
            //{
            //    Console.WriteLine(d.Key + " :" + d.Value);
            //}
            Groups groups=new Groups();
            List<Groups> grp = new List<Groups>
            {new Groups{id=01, name="ashiq",value=true,Mark=49.5 },
            new Groups{id=02, name="sam",value=false,Mark=75.7 },
            new Groups{id=03, name="George",value=true,Mark=99.9 }
            };
           
           
            foreach(Groups g in grp)
            {
                Console.WriteLine(g.id+":"+g.name+ ":" +g.value+ ":" +g.Mark);
            }
            
            //List<int> lst = new List<int>();

            //lst.Add(100);
            //lst.Add(200);
            //lst.Add(300);
            //lst.Add(400);
            //lst.Add(500);
            //Console.WriteLine(lst.Capacity);
            //Console.WriteLine(lst.Capacity);
            //foreach (int item in lst)
            //{
            //    Console.WriteLine(item);
            //}


            //Dictionary<int, string> dct = new Dictionary<int, string>();
            //dct.Add(001, "Ashiq");
            //dct.Add(002, "vishnu");
            //dct.Add(003, "Aydu");
            //dct.Add(004, "Hashi");
            //foreach (KeyValuePair<int, string> kvp in dct)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //    Console.WriteLine("\n");
            //}

            //SortedList<int, string> sl = new SortedList<int, string>();
            //sl.Add(1, "oracle");
            //sl.Add(2, "vb.net");
            //sl.Add(3, "cs.net");
            //sl.Add(4, "asp.net");

            //foreach (KeyValuePair<int, string> kvp in sl)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //    Console.Write("\n");
            //}

            //Queue<string> q = new Queue<string>();

            //q.Enqueue("cs.net");
            //q.Enqueue("vb.net");
            //q.Enqueue("asp.net");
            //q.Enqueue("sqlserver");
            //q.Dequeue();
            //foreach (string s in q)
            //{
            //    Console.Write(s + "\n");
            //}


            //Console.Write("\n");

            //Stack<string> stk = new Stack<string>();
            //stk.Push("rahul");
            //stk.Push("sachin");
            //stk.Push("Ganguly");
            //stk.Push("Laxman");
            //stk.Pop();

            //foreach (string s in stk)
            //{
            //    Console.Write(s + "\n");
            //}
            Console.ReadKey();
        }
    }
}
