using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Stringdemo
{
    class Email
    {
        static void Main(string[] args)
        {
            int t = 0;int t1 = 0;
            Console.WriteLine("enter email");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                t = s.IndexOf("@");
                t1 = s.IndexOf(".");
            }
            
                if (t!=-1 && t1 !=-1)
                {
                    Console.WriteLine("valid");

                }else
                {
                    Console.WriteLine("not valid");
                }
            }
            
        }
    }

