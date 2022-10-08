using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.conditional
{
    class start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());
            /* if (num1 % 2 == 0)
             {
                 Console.WriteLine("number is Even " + num1);

             }
             else
             {
                 Console.WriteLine("number is ODD " + num1);
             }
         } 
            */
            if (num1 % 5 == 0)

            {
                Console.WriteLine("number is divisible " + num1);


            }
            else
            {
                Console.WriteLine("number is not divisible " + num1);

            }
        }
    }
}
