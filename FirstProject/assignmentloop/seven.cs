using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.assignment
{
    class seven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
           
        
                int i, sum = 0;

               
                for (i = 1; i <= n; i += 2)
                {
                    sum += i;
                }

            Console.WriteLine ("Sum of odd numbers "+ sum);

               
            }
           
        }
    }

