using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Functionuse
    {
        static void Main(string[] args)
        {
            string s = "priyashree";
            string s1 = s.ToUpper();
            s1.CompareTo(s);
            int idx = s1.IndexOf('m');
            int idxx = s1.LastIndexOf('e');
            string[] sarr = s1.Split(" ");
            char[] arr = s1.ToCharArray();
            Console.WriteLine(s1.Length);
            string s2 = s.Replace("priyashree", "shree");
            string s5 = s.Substring(2, 3);
            s = s.Trim();
            Console.WriteLine(s.Equals(s1));
            Console.WriteLine(s1+s2+s5);


        }
    }
}
