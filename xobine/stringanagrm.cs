using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.xobine
{
    class stringanagrm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string s = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string s1 = Console.ReadLine();

            char[] ch = s.ToCharArray();
            char[] ch1 = s1.ToCharArray();

            System.Array.Sort(ch);
            System.Array.Sort(ch1);

            string val1 = new string(ch);
            string val2 = new string(ch1);

            if(val1== val2)
            {
                Console.WriteLine("anagram");
            }else
            {
                Console.WriteLine("not angram");
            }



        }
    }
}
