using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Namevalidation
    {
        public static string Name(string s)
        {
            int count = 0; int count1 = 0;
            foreach (char c in s)
            {

                if (char.IsUpper(c))
                {
                    count++;
                    break;

                }

                else if (char.IsLower(c))
                {
                    count1++;
                    break;
                }
                else
                {
                    char.IsDigit(c);
                    continue;
                }
                if(count==1)
                {
                    Console.WriteLine("valid");
                }
            }
            return s;

        }
            
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string s = Console.ReadLine();
            Namevalidation.Name(s);
            Console.WriteLine(s);

        }
    }
}
