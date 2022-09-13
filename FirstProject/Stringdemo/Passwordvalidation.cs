using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Passwordvalidation
    {

        public static string CheckPassword(string pass)
        {
            int count=0, count1=0, count2 =0;
            foreach (char c in pass)
            {
                if (pass.Length<=8)
                {
                    
                    break;
                }
            }
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    count++;
                    Console.WriteLine(count);
                    break;
                }
            }
            foreach (char c in pass)
            {
                if (char.IsLower(c))
                {
                    count1++;
                    Console.WriteLine(count1);
                    break;
                }
            }
            foreach (char c in pass)
            {
                if (char.IsDigit(c))
                {
                    count2++;
                    Console.WriteLine(count2);
                    break;
                }
            } 
            if(count==1 &&count1==1&& count2==1)
            {
                Console.WriteLine("valid");
            }
            return pass;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter password");
            string s = Console.ReadLine();
            string s1= Passwordvalidation.CheckPassword(s);
            Console.WriteLine(s1);
            

        }
    }
}
