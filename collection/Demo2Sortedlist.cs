using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class Demo2Sortedlist
    {
        static void Main(string[] args)
        {
            SortedList<Trainner, string> ss = new SortedList<Trainner, string>();
            ss.Add(new Trainner(101, "medha"), "java");
            ss.Add(new Trainner(102, "kirti"), "c#");
            ss.Add(new Trainner(103, "deepa"), "c++");

            foreach(KeyValuePair<Trainner,string> kv in ss)
                Console.WriteLine(kv.Key+"==>"+kv.Value);
        }
        sealed class Trainer:IComparable<Trainer>
        {
            int trainerid;
            string trainername;

            public int CompareTo(Trainer t2)
            {
                return this.trainername.CompareTo(t2.trainername);
            }
        }
    }
}
