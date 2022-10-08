using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.interview
{
   
        class Series
        {
            static void Main(string[] args)
            {
                int n, i, pr = 0;
                Console.WriteLine("Enter the range of number(Limit)");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    pr = (pr * 2) + 1;
                    Console.WriteLine(pr);
                }
            }
        }
    }

