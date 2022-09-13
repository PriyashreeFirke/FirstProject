using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
    class Anagram
    {
        public static bool Check(string str1, string str2)
        {
            int n = str1.Length;
            int n1 = str2.Length;

            if (n!=n1)
            {
               
                    return false;
               
            }
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            char[] a1 = str1.ToCharArray();
            char[] a2 = str2.ToCharArray();

            System.Array.Sort(a1);
            System.Array.Sort(a2);

            for(int i=0;i<n;i++)
            {
                if(a1==a2)
                {
                    return false;
                }
            }
            return true;

            
        }
            static void Main(string[] args)
            {
            string str1 = "test";
            string str2 = "rest";
            if (Check(str1, str2))
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }


            }
        }
    }

