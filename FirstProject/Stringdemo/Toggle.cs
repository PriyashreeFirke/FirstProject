using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Toggle
    {
         static string Toggles(string str)
        {
            string t = "";
            foreach(char c in str)
            {
                if(char.IsUpper(c))
                {
                    char ch = char.ToLower(c);
                    t = t + ch;
                }
                else if(char.IsLower(c))
                {
                    t=t+char.ToUpper(c);
                }
            }
            return t;
        }
        static void Main(string[] args)
        {
            string s = "priyashree Firke";
            string togglestr = Toggles(s);
            Console.WriteLine(togglestr);
        }
    }
}
