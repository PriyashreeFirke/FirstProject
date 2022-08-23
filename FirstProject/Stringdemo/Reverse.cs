using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Reverse
    {
        static string Reverse1(string s)
        {
            string rev = "";
            for(int i=s.Length-1;i>=0 ;i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            string s = "shanaya goes to bishops school";
            string[] sarr = s.Split();
            for(int i=0;i<sarr.Length;i++)
            {
                string r = Reverse1(sarr[i]);
                Console.WriteLine(r+"");
            }
        }
    }
}
