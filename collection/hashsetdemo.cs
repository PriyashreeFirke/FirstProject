using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProject.collection
{
    class hashsetdemo
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("priyashree");
            hs.Add("ria");
            hs.Add("puja");
            hs.Add("ria");//duplicate not allow so dont print this line also bool type so no show error
            foreach(string s in hs)
            {
                Console.WriteLine(hs);


            }
            HashSet<string> hs1 = new HashSet<string>();
            hs.Add("deepa");
            hs.Add("sonal");
            hs.Add("puja");
            hs.Add("ria");
            foreach(string s in hs1)
            {
                Console.WriteLine(hs1);
            }

            hs.IntersectWith(hs1);// show only common
            HashSet<string> h3=hs.Intersect(hs1).ToHashSet();

            hs.UnionWith(hs1);//show all element
        }
    }
}
