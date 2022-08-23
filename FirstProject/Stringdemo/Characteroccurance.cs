using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Characteroccurance
    {
        public static int  Character(string s,char c)
        {
            int n = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(c==s[i])
                {
                    n++;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            String s = Console.ReadLine();
            Console.WriteLine("enter character");
            char c = char.Parse(Console.ReadLine());
           int a= Characteroccurance.Character(s, c);
            Console.WriteLine(a);

        }
    }
}
