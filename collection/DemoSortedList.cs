using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{
    class DemoSortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("pranav", 90);
            ss.Add("Avinash", 90);
            ss.Add("Akshy", 80);
            ss.Add("Devesh", 90);
            ss["Akshy"] = 93;
            ss.Remove("Devesh");
            foreach(KeyValuePair<string,int> kv in ss)
                Console.WriteLine(kv.Key+"==>"+kv.Value);

            foreach(string k in ss.Keys)
            {
                Console.WriteLine(k+"==>"+ss[k]);
            }
        }
    }
}
