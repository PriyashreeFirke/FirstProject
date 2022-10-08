using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string s1 = "Race";
            string s2 = "Care";
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            string[] a3 = s1.Split(" ");

            System.Array.Sort(a1);
            System.Array.Sort(a2);

            if(string.Join("",a1)==string.Join("",a2))
                Console.WriteLine("Annagram");
            else
                Console.WriteLine("not");
        }
    }
}
