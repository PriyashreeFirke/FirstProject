using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.collection
{

    class Mysortstringbuilder : IComparer<stringbuilder>
    {
        public int Compare(stringbuilder sb1, stringbuilder sb2)
        {
            string s1 = sb1.ToString();
            string s2 = sb2.ToString();
            return s1.CompareTo(s2);
        }
    }
    class stringbuilder
    {
        static void Main(string[] args)
        {
            List<StringBuilder> lst = new List<StringBuilder>();
            lst.Add(new StringBuilder("priyashree"));
            lst.Add(new StringBuilder("ria"));
            lst.Add(new StringBuilder("komal"));
           // lst.Sort(new Mysortstringbuilder());
           
           foreach(StringBuilder ob in lst)
                Console.WriteLine(ob);
            

        }
    }
}
