using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Remove
    {
        static void Main(string[] args)
        {
            string s1,s2,s3,s4, s5= null;
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                     s1 = s.Replace('a','b');
                    s2 = s1.Replace('e', 'f');
                    s3 = s2.Replace('i', 'j');
                    s4 = s3.Replace('o','p');
                    s5 = s4.Replace('u','v');

                }
                
            }
            Console.WriteLine(s5);
            
        }
    }
}
